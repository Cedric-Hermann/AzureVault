using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureVault
{
    public partial class KeyFunktionen
    {
        public static string GetCryptionKeys(string neededKey)
        {
            string idForCharsetKey = "keyForCharset";
            string idForLaengeKey = "keyForLaenge";
            string idForDopplungKey = "keyForDopplung";
            string idForTitelKey = "keyForTitel";
            string idForUsernameKey = "keyForUsername";
            string idForPasswortKey = "keyForPasswort";
            string idForUrlKey = "keyForUrl";
            string idForMasterKey = "keyForMaster";

            string charsetKey = "pn6d6v4mr2nc30pvkp8sa7r89g01o2ps";
            string laengeKey = "j30en3rc18knn9nbprbov9od58xwh12q";
            string dopplungKey = "c3fgo5jsuk2vgh490rrwgcm2g669e7hr";
            string titelKey = "7a573c0747f57a677852cdf78937c7e6";
            string usernameKey = "b332ed1f8aac7451a5a6e2ec3f8029fa";
            string passwortKey = "6dcd4ce23d88e2ee95838f7b014b628e";
            string urlKey = "3fa85f64c2f680956a4f0a2e0a36f5ab";
            string masterKey = "e546c8df278cd5931069b522e6953332";

            if (neededKey == idForCharsetKey)
                return charsetKey;
            if( neededKey == idForLaengeKey)
                return laengeKey;
            if(neededKey == idForDopplungKey)
                return dopplungKey;
            if(neededKey ==idForTitelKey)
                return titelKey;
            if(neededKey == idForUsernameKey)
                return usernameKey;
            if(neededKey == idForPasswortKey)
                return passwortKey;
            if (neededKey == idForUrlKey)
                return urlKey;
            if(neededKey == idForMasterKey)
                return masterKey;
            else
                return "error";
        }
    }
}
