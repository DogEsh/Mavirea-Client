using UnityEngine;
using Mavirea.GameInfo;
using Mavirea.BinarySerialization;
using System.IO;
using System;

namespace Mavirea
{
    public class SceneLoader : MonoBehaviour
    {
        private IMapInfo myMap;
        private IMapInfo mytestMap;
        bool ok1;
        bool ok2;
        // Use this for initialization
        void Start()
        {
            myMap = CreateMapInfo();
            
            bool ok = Check();

        }
        public bool Check()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (FileStream outputFile = File.Create(mydocpath + @"\WriteLines.txt"))
            {
                Stream s = outputFile as Stream;
                IConverter convert = new ConverterDotNet();
                ok1 = convert.Pack(ref s, myMap);

            }

            using (FileStream outputFile = File.OpenRead(mydocpath + @"\WriteLines.txt"))
            {
                Stream s = outputFile as Stream;
                IConverter convert = new ConverterDotNet();
                ok2 = convert.Unpack(ref mytestMap, s);

            }

            return true;
        }
        public IMapInfo CreateMapInfo()
        {
            ISimplusInfo simplus;
            Circle circle;
            ISimplusHP simplusHp;
            IParty party;
            ILinkInfoContainer linkContainer;
            IGameObjContainer<ISimplusInfo> mySimplus;

            linkContainer = new LinkInfoList();
            party = new Party(5);
            simplusHp = new SimplusHP(10, 100, 10);
            circle = new Circle(new Vector2(0, 0), 3f);
            simplus = new SimplusInfo(1, circle, simplusHp, party, linkContainer);
            mySimplus = new GameObjList<ISimplusInfo>();
            mySimplus.SetObj(simplus);
            IMapInfo mapInfo = new MapInfo(16, 9, mySimplus);
            return mapInfo;
        }
    }
}
