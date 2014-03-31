using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

public class XMLTest : MonoBehaviour {

		public List<XmlBaseObject> objectsList  = new List<XmlBaseObject>();
		public GameObject o;



	void Start () {
				XmlReader reader = XmlReader.Create (Application.loadedLevelName + ".xml");
				while (reader.Read ()) {
						if(reader.IsStartElement()){
								switch (reader.Name)
								{
								case "name":
										reader.Read ();
										Debug.Log (reader.Value);
										break;
								case "time":
										reader.Read();
										Debug.Log (reader.Value);
										break;
								case "rank":
										reader.Read();
										Debug.Log (reader.Value);
										break;
								}

						}
				}
				string s = System.DateTime.Now.ToString();
				Debug.Log (s);
	}
	
	
	void Update () {

				if (Input.GetMouseButton (0))
						AddObject ();
	
	}
		void OnDestroy()
		{
				XmlWriter writer = null;
				XmlWriterSettings settings = new XmlWriterSettings ();
				settings.Indent = true;
				settings.IndentChars = ("\t");
				settings.OmitXmlDeclaration = true;

				writer = XmlWriter.Create(Application.loadedLevelName+".xml", settings);
				writer.WriteStartElement(Application.loadedLevelName);


				for (int i = 0; i < objectsList.Count; i++) {
						writer.WriteStartElement("djur");
						writer.WriteElementString("name", objectsList[i].name);
						writer.WriteElementString("time", objectsList[i].time);
						writer.WriteElementString("rank", objectsList[i].rank.ToString());
						writer.WriteEndElement();
				}
				writer.WriteEndElement();
				writer.Flush();

				if (writer != null) {
						writer.Close ();
				}



				Debug.Log ("Sparar");


		}
		public void AddObject()
		{
				XmlBaseObject temp = new XmlBaseObject ();
				temp.name = "ko" + objectsList.Count;
				temp.time = Time.time.ToString ();
				temp.rank = Random.Range (0.0f, 1.0f);
				objectsList.Add (temp);
				Debug.Log (temp.name+temp.time.ToString()+temp.rank);


		}
	

}
