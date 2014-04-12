﻿namespace FsBulletML

open System
open System.IO 
open System.Text 
open System.Xml
open System.Text.RegularExpressions
open System.Runtime.CompilerServices
open System.Runtime.InteropServices
open FParsec
open FsBulletML
open FsBulletML.Processable 

[<AutoOpen>]
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Bulletml = 

  type Bulletml with

#if NET40
    [<CompiledName "ReadXmlString">]
    static member ReadXmlString (xml : string, [<Optional; DefaultParameterValue(DtdProcessing.Ignore)>]?dtdProcessing) : Bulletml = 
      let dtdProcessing = defaultArg dtdProcessing DtdProcessing.Ignore
      use reader = new System.IO.StringReader(xml)
      use reader = XmlReader.Create(reader, readerSettingsIndented dtdProcessing) 
      XmlNode.Read(xml, reader) |> IntermediateParser.convertBulletmlFromXmlNode
    [<CompiledName "TryReadXmlString">]
    static member TryReadXmlString (xml : string, [<Optional; DefaultParameterValue(DtdProcessing.Ignore)>]?dtdProcessing) : Bulletml option = 
      let dtdProcessing = defaultArg dtdProcessing DtdProcessing.Ignore
      use reader = new System.IO.StringReader(xml)
      use reader = XmlReader.Create(reader, readerSettingsIndented dtdProcessing) 
      XmlNode.Read(xml, reader) |> IntermediateParser.tryBulletmlFromXmlNode
#endif
#if NET35
    [<CompiledName "ReadXmlString">]
    static member ReadXmlString (xml : string) : Bulletml = 
      use reader = new System.IO.StringReader(xml)
      use reader = XmlReader.Create(reader, readerSettingsIndented) 
      XmlNode.Read(xml, reader) |> IntermediateParser.convertBulletmlFromXmlNode
    [<CompiledName "TryReadXmlString">]
    static member TryReadXmlString (xml : string) : Bulletml option = 
      use reader = new System.IO.StringReader(xml)
      use reader = XmlReader.Create(reader, readerSettingsIndented) 
      XmlNode.Read(xml, reader) |> IntermediateParser.tryBulletmlFromXmlNode
#endif

#if NET40
    [<CompiledName "ReadXml">]
    static member ReadXml (xmlFile : string, [<Optional; DefaultParameterValue(DtdProcessing.Ignore)>]?dtdProcessing) : Bulletml =
      let dtdProcessing = defaultArg dtdProcessing DtdProcessing.Ignore
      use reader = XmlReader.Create((xmlFile:string), readerSettingsIndented dtdProcessing) 
      XmlNode.Read(xmlFile, reader) |> IntermediateParser.convertBulletmlFromXmlNode
    [<CompiledName "TryReadXml">]
    static member TryReadXml (xmlFile : string, [<Optional; DefaultParameterValue(DtdProcessing.Ignore)>]?dtdProcessing) : Bulletml option =
      let dtdProcessing = defaultArg dtdProcessing DtdProcessing.Ignore
      use reader = XmlReader.Create((xmlFile:string), readerSettingsIndented dtdProcessing) 
      XmlNode.Read(xmlFile, reader) |> IntermediateParser.tryBulletmlFromXmlNode
#endif
#if NET35
    [<CompiledName "ReadXml">]
    static member ReadXml (xmlFile : string) : Bulletml =
      use reader = XmlReader.Create((xmlFile:string), readerSettingsIndented) 
      XmlNode.Read(xmlFile, reader) |> IntermediateParser.convertBulletmlFromXmlNode
    [<CompiledName "TryReadXml">]
    static member TryReadXml (xmlFile : string) : Bulletml option =
      use reader = XmlReader.Create((xmlFile:string), readerSettingsIndented) 
      XmlNode.Read(xmlFile, reader) |> IntermediateParser.tryBulletmlFromXmlNode
#endif

    [<CompiledName "ReadSxmlString">]
    static member ReadSxmlString (sxml : string) : Bulletml =
      match Sxml.parse sxml with 
      | Success (r,_,_) -> r |> IntermediateParser.convertBulletmlFromXmlNode 
      | Failure (_,_,_) -> failwith "sxml parse error"

    [<CompiledName "TryReadSxmlString">]
    static member TryReadSxmlString (sxml : string) : Bulletml option =
      match Sxml.parse sxml with 
      | Success (r,_,_) -> r |> IntermediateParser.tryBulletmlFromXmlNode 
      | Failure (_,_,_) -> None

    [<CompiledName "ReadSxml">]
    static member ReadSxml (sxmlFile : string) : Bulletml =
      match Sxml.parseFromFile sxmlFile with 
      | Success (r,_,_) -> r |> IntermediateParser.convertBulletmlFromXmlNode 
      | Failure (_,_,_) -> failwith "sxml parse error"

    [<CompiledName "TryReadSxml">]
    static member TryReadSxml (sxmlFile : string) : Bulletml option =
      match Sxml.parseFromFile sxmlFile with 
      | Success (r,_,_) -> r |> IntermediateParser.tryBulletmlFromXmlNode 
      | Failure (_,_,_) -> None

    [<CompiledName "ReadFsbString">]
    static member ReadFsbString (fsb: string) : Bulletml =
      match Offside.parse fsb with 
      | Success (r,_,_) -> r |> IntermediateParser.convertBulletmlFromXmlNode
      | Failure (_,_,_) -> failwith "fsb parse error"

    [<CompiledName "TryReadFsbString">]
    static member TryReadFsbString (fsb: string) : Bulletml option =
      match Offside.parse fsb with 
      | Success (r,_,_) -> r |> IntermediateParser.tryBulletmlFromXmlNode
      | Failure (_,_,_) -> None

    [<CompiledName "ReadFsb">]
    static member ReadFsb (fsbFile : string) : Bulletml =
      match Offside.parseFromFile fsbFile with 
      | Success (r,_,_) -> r |> IntermediateParser.convertBulletmlFromXmlNode
      | Failure (_,_,_) -> failwith "fsb parse error"

    [<CompiledName "TryReadFsb">]
    static member TryReadFsb (fsbFile : string) : Bulletml option =
      match Offside.parseFromFile fsbFile with 
      | Success (r,_,_) -> r |> IntermediateParser.tryBulletmlFromXmlNode
      | Failure (_,_,_) -> None

    member this.ToNodeString() = 
      this.ToString().Replace("null","None")

    member this.ToXmlString() =
      let recBulletml = this |> IntermediateParser.convertRecBulletml 
      recBulletml.ToXmlString()

    member this.ToXmlStringForTest() =
      let recBulletml = this |> IntermediateParser.convertRecBulletmlForTest
      recBulletml.ToXmlString()

    member this.ToXmlString(?encodingAndDoctype) = 
      let recBulletml = this |> IntermediateParser.convertRecBulletml 
      let encodingAndDoctype = defaultArg encodingAndDoctype EncodingAndDoctype.Nothing
      recBulletml.ToXmlString(encodingAndDoctype)

    member this.ToXmlStringForTest(?encodingAndDoctype) = 
      let recBulletml = this |> IntermediateParser.convertRecBulletmlForTest
      let encodingAndDoctype = defaultArg encodingAndDoctype EncodingAndDoctype.Nothing
      recBulletml.ToXmlString(encodingAndDoctype)

    member this.ToIndentedXmlString([<Optional; DefaultParameterValue(4)>]?indentation : int, ?encodingAndDoctype) =
      let recBulletml = this |> IntermediateParser.convertRecBulletml 
      let indentation = defaultArg indentation 4
      let encodingAndDoctype = defaultArg encodingAndDoctype EncodingAndDoctype.Nothing
      recBulletml.ToIndentedXmlString(indentation, encodingAndDoctype)

    member this.ToIndentedXmlStringForTest([<Optional; DefaultParameterValue(4)>]?indentation : int, ?encodingAndDoctype) =
      let recBulletml = this |> IntermediateParser.convertRecBulletmlForTest
      let indentation = defaultArg indentation 4
      let encodingAndDoctype = defaultArg encodingAndDoctype EncodingAndDoctype.Nothing
      recBulletml.ToIndentedXmlString(indentation, encodingAndDoctype)