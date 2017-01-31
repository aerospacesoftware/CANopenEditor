﻿/* 
  Licensed under the Apache License, Version 2.0
 * 
 * The XML contents of this file are auto generated by XML to C#
    
  http://www.apache.org/licenses/LICENSE-2.0
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Xml2CSharp;
using System.IO;

namespace libEDSsharp
{
    public class CanOpenXML
    {
        public Device dev;
        public void readXML(string file)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Device));
            StreamReader reader = new StreamReader(file);
            dev = (Device)serializer.Deserialize(reader);
            reader.Close();
        }

        public void writeXML(string file)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Device));
            StreamWriter writer = new StreamWriter(file);
            serializer.Serialize(writer, dev);
            writer.Close();
        }
    }


    public class NetworkXML
    {
        Network network = new Network();

        public List<Device> readXML(string file)
        {       
            XmlSerializer serializer = new XmlSerializer(typeof(Network));
            StreamReader reader = new StreamReader(file);
            network = (Network)serializer.Deserialize(reader);
            reader.Close();
            return network.devices;
        }

        public void writeXML(string file, List<EDSsharp> enet)
        {

            network.devices = new List<Device>();
            foreach(EDSsharp e in enet)
            {
                Bridge b = new Bridge();
                Device d = b.convert(e);
                network.devices.Add(d);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Network));
            StreamWriter writer = new StreamWriter(file);
            serializer.Serialize(writer, network);
            writer.Close();
        }
    }
}

namespace Xml2CSharp
{
	[XmlRoot(ElementName="label")]
	public class Label {
		[XmlAttribute(AttributeName="lang")]
		public string Lang { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="description")]
	public class Description {
		[XmlAttribute(AttributeName="lang")]
		public string Lang { get; set; }
		[XmlAttribute(AttributeName="URI")]
		public string URI { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="associatedObject")]
	public class AssociatedObject {
		[XmlAttribute(AttributeName="index")]
		public string Index { get; set; }
		[XmlAttribute(AttributeName="indexMax")]
		public string IndexMax { get; set; }
		[XmlAttribute(AttributeName="indexStep")]
		public string IndexStep { get; set; }
	}

	[XmlRoot(ElementName="feature")]
	public class Feature {
		[XmlElement(ElementName="label")]
		public Label Label { get; set; }
		[XmlElement(ElementName="description")]
		public Description Description { get; set; }
		[XmlElement(ElementName="associatedObject")]
		public List<AssociatedObject> AssociatedObject { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName="features")]
	public class Features {
		[XmlElement(ElementName="feature")]
		public List<Feature> Feature { get; set; }
	}

	[XmlRoot(ElementName="CANopenObject")]
	public class CANopenObject {
		[XmlElement(ElementName="label")]
		public Label Label { get; set; }
		[XmlElement(ElementName="description")]
		public Description Description { get; set; }
		[XmlAttribute(AttributeName="index")]
		public string Index { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="objectType")]
		public string ObjectType { get; set; }
		[XmlAttribute(AttributeName="memoryType")]
		public string MemoryType { get; set; }
		[XmlAttribute(AttributeName="dataType")]
		public string DataType { get; set; }
		[XmlAttribute(AttributeName="accessType")]
		public string AccessType { get; set; }
		[XmlAttribute(AttributeName="PDOmapping")]
		public string PDOmapping { get; set; }
		[XmlAttribute(AttributeName="defaultValue")]
		public string DefaultValue { get; set; }
		[XmlElement(ElementName="CANopenSubObject")]
		public List<CANopenSubObject> CANopenSubObject { get; set; }
		[XmlAttribute(AttributeName="subNumber")]
		public string SubNumber { get; set; }
		[XmlAttribute(AttributeName="accessFunctionName")]
		public string AccessFunctionName { get; set; }
		[XmlAttribute(AttributeName="disabled")]
		public string Disabled { get; set; }
		[XmlElement(ElementName="accessFunctionPreCode")]
		public string AccessFunctionPreCode { get; set; }
		[XmlAttribute(AttributeName="TPDOdetectCOS")]
		public string TPDOdetectCOS { get; set; }
    }

	[XmlRoot(ElementName="CANopenSubObject")]
	public class CANopenSubObject {
		[XmlAttribute(AttributeName="subIndex")]
		public string SubIndex { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="objectType")]
		public string ObjectType { get; set; }
		[XmlAttribute(AttributeName="dataType")]
		public string DataType { get; set; }
		[XmlAttribute(AttributeName="accessType")]
		public string AccessType { get; set; }
		[XmlAttribute(AttributeName="PDOmapping")]
		public string PDOmapping { get; set; }
		[XmlAttribute(AttributeName="defaultValue")]
		public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "TPDOdetectCOS")]
        public string TPDOdetectCOS { get; set; }
    }

	[XmlRoot(ElementName="CANopenObjectList")]
	public class CANopenObjectList {
		[XmlElement(ElementName="CANopenObject")]
		public List<CANopenObject> CANopenObject { get; set; }
	}

	[XmlRoot(ElementName="file")]
	public class File {
		[XmlAttribute(AttributeName="fileName")]
		public string FileName { get; set; }
		[XmlAttribute(AttributeName="fileCreator")]
		public string FileCreator { get; set; }
		[XmlAttribute(AttributeName="fileCreationDate")]
		public string FileCreationDate { get; set; }
		[XmlAttribute(AttributeName="fileCreationTime")]
		public string FileCreationTime { get; set; }
        [XmlAttribute(AttributeName = "fileModifedBy")]
        public string FileModifedBy { get; set; }
        [XmlAttribute(AttributeName = "fileMotifcationDate")]
        public string FileModificationDate { get; set; }
        [XmlAttribute(AttributeName = "fileModificationTime")]
        public string FileModificationTime { get; set; }
        [XmlAttribute(AttributeName="fileVersion")]
		public string FileVersion { get; set; }
        [XmlAttribute(AttributeName = "fileRevision")]
        public byte FileRevision { get; set; }
        [XmlAttribute(AttributeName = "exportFolder")]
        public string ExportFolder { get; set; }

    }

    [XmlRoot(ElementName="productText")]
	public class ProductText {
		[XmlElement(ElementName="label")]
		public Label Label { get; set; }
		[XmlElement(ElementName="description")]
		public Description Description { get; set; }
	}

	[XmlRoot(ElementName="DeviceIdentity")]
	public class DeviceIdentity {
		[XmlElement(ElementName="vendorName")]
		public string VendorName { get; set; }
        [XmlElement(ElementName = "vendorNumber")]
        public uint VendorNumber { get; set; }
        [XmlElement(ElementName="productName")]
		public string ProductName { get; set; }
		[XmlElement(ElementName="productNumber")]
        public uint ProductNumber { get; set; }
        [XmlElement(ElementName = "productText")]
        public ProductText ProductText { get; set; }
        [XmlElement(ElementName = "concreteNoideId")]
        public string ConcreteNoideId { get; set; }
	}

	[XmlRoot(ElementName="characteristicName")]
	public class CharacteristicName {
		[XmlElement(ElementName="label")]
		public Label Label { get; set; }
	}

	[XmlRoot(ElementName="characteristicContent")]
	public class CharacteristicContent {
		[XmlElement(ElementName="label")]
		public Label Label { get; set; }
	}

	[XmlRoot(ElementName="characteristic")]
	public class Characteristic {
		[XmlElement(ElementName="characteristicName")]
		public CharacteristicName CharacteristicName { get; set; }
		[XmlElement(ElementName="characteristicContent")]
		public CharacteristicContent CharacteristicContent { get; set; }
	}

	[XmlRoot(ElementName="characteristicsList")]
	public class CharacteristicsList {
		[XmlElement(ElementName="characteristic")]
		public List<Characteristic> Characteristic { get; set; }
	}

	[XmlRoot(ElementName="capabilities")]
	public class Capabilities {
		[XmlElement(ElementName="characteristicsList")]
		public CharacteristicsList CharacteristicsList { get; set; }
	}

	[XmlRoot(ElementName="supportedBaudRate")]
	public class SupportedBaudRate {
		[XmlAttribute(AttributeName="value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName="baudRate")]
	public class BaudRate {
		[XmlElement(ElementName="supportedBaudRate")]
		public List<SupportedBaudRate> SupportedBaudRate { get; set; }
	}

	[XmlRoot(ElementName="dummy")]
	public class Dummy {
		[XmlAttribute(AttributeName="entry")]
		public string Entry { get; set; }
	}

	[XmlRoot(ElementName="dummyUsage")]
	public class DummyUsage {
		[XmlElement(ElementName="dummy")]
		public List<Dummy> Dummy { get; set; }
	}

	[XmlRoot(ElementName="other")]
	public class Other {
		[XmlElement(ElementName="file")]
		public File File { get; set; }
		[XmlElement(ElementName="DeviceIdentity")]
		public DeviceIdentity DeviceIdentity { get; set; }
		[XmlElement(ElementName="capabilities")]
		public Capabilities Capabilities { get; set; }
		[XmlElement(ElementName="baudRate")]
		public BaudRate BaudRate { get; set; }
		[XmlElement(ElementName="dummyUsage")]
		public DummyUsage DummyUsage { get; set; }
	}

	[XmlRoot(ElementName="device")]
	public class Device {
		[XmlElement(ElementName="features")]
		public Features Features { get; set; }
		[XmlElement(ElementName="CANopenObjectList")]
		public CANopenObjectList CANopenObjectList { get; set; }
		[XmlElement(ElementName="other")]
		public Other Other { get; set; }
	}

    [XmlRoot(ElementName = "network")]
    public class Network
    {
        [XmlElement(ElementName = "devices")]
        public List<Device> devices { get; set; }
    }


}
