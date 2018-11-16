using AMEISA.DAO;
using AMEISA.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AMEISA
{
    class Program
    {
        int like = 0;
        List<int> rank = new List<int>();

        static void Main(string[] args)
        {
            string str = "MNNQRKKTARPSFNMLKRARNRVSTVSQLAKRFSKGLLSGQGPMKLVMAFIAFLRFLAIPPTAGILARWGSFKKNGAIKVLRGFKKEISSMLNIMNRRKRSVTMLLMLMPTALAFHLTTRGGEPHMIVSKQERGKSLLFKTSAGVNMCTLIAMDLGELCEDTMTYKCPRITEAEPDDVDCWCNATDTWVTYGTCSQTGEHRRDKRSVALAPHVGLGLETRTETWMSSEGAWKQIQRVETWALRHPGFTVIALFLAHAIGTSITQKGIIFILLMLVTPSMAMRCVGIGSRDFVEGLSGATWVDVVLEHGSCVTTMAKDKPTLDIELLKTEVTNPAVLRKLCIEAKISNTTTDSRCPTQGEATLVEEQDANFVCRRTFVDRGWGNGCGLFGKGSLITCAKFKCVTKLEGKIVQYENLKYSVIVTVHTGDQHQVGNESTEHGTTATITPQAPTTEIQLTDYGALTLDCSPRTGLDFNEMVLLTMKEKSWLVHKQWFLDLPLPWTSGASTSQETWNRQDLLVTFKTAHAKKQEVVVLGSQEGAMHTALTGATEIQTSGTTTIFAGHLKCRLKMDKLTLKGMSYVMCTGSFKLEKEVAETQHGTVLVQIKYEGTDAPCKIPFSTQDEKGVTQNGRLITANPIVTDKEKPVNIEAEPPFGESHIVIGAGEKALKLSWFKKGSSIGKMFEATARGARRMAILGDTAWDFGSIGGVFTSVGKLVHQIFGTAYGVLFSGVSWTMKIGIGVLLTWLGLNSRSTSLSMTCIAVGLVTLYLGVMVQADSGCVINWKGRELKCGSGIFVTNEVHTWTEQYKFQADSPKRLSAAIGKAWEEGVCGIRSATRLENIMWKQISNELNHILLENDMKFTVVVGDVAGILAQGKKMISPQPMEHKYSWKSWGKAKIIGADVQNTTFIIDGPNTPECPDDQRAWNIWEVEDYGFGIFTTNIWLKLRDSYTQVCDHRLMSAAIKDSKAVHADMGYWIESEKNETWKLARASFIEVKTCIWPKSHTLWSNGVLESEMIIPKIYGGPISQHNYRPGYFTQTAGPWHLGKLELDFDLCEGTTVVVDEHCGSRGPSLRTTTVTGKIIHEWCCRSCTLPPLRFRGEDGCWYGMEIRPVKEKEENLVKSMVSAGSGEVDSFSLGLLCISIMIEEVMRSRWSRKMLMTGTLAVFFLLIMGQLTWNDLIRLCIMVGANASDRMGMGTTYLALMATFKMRPMFAVGLLFRRLTSREVLLLTIGLSLVASVELPNSLEELGDGLAMGIMILKLLTDFQSHQLWATLLSLTFIKTTFSLHYAWKTVAMVLSIVSLFPLCLSTTSQKTTWLPVLLGSLGCKPLTMFLIAENKIWGRKSWPLNEGIMAVGIVSILLSSLLKNDVPLAGPLIAGGMLIACYDMSGSSADLSLEKAAEVSWEEEAEHSGASHNILVEVQDDGTMKIKDEERDDTLTILLKATLLAISGVYPLSIPATLFVWYFWQKKKQRSGVLWDTPSPPEVERAVLDDGIYRIMQRGLLGRSQVGVGVFQENVFHTMWHVTRGAVLMYQGKRLEPSWASVKKDLISYGGGWRLQGSWNTGEEVQVIAVEPGKNPKNVQTAPGTFKTPEGEVGAIALDFKPGTSGSPIVNREGKIVGLYGNGVVTTSGTYVSAIAQAKASQEGPLPEIEDEVFRKRNLTIMDLHPGSGKTRRYLPAIVREAIKRKLRTLILAPTRVVASEMAEALKGMPIRYQTTAVKSEHTGKEIVDLMCHATFTMRLLSPVRVPNYNMIIMDEAHFTDPSSIAARGYISTRVGMGEAAAIFMTATPPGSVEAFPQSNAVIQDEERDIPERSWNSGYEWITDFPGKTVWFVPSIKSGNDIANCLRKNGKRVIQLSRKTFDTEYQKTKNNDWDYVVTTDISEMGANFRADRVIDPRRCLKPVILKDGPERVILAGPMPVTVASAAQRRGRIGRNHNKEGDQYIYMGQPLNNDEDHAHWTEAKMLLDNINTPEGIIPALFEPEREKSAAIDGEYRLRGEARKTFVELMRRGDLPVWLSYKVASEGFQYSDRRWCFDGERNNQVLEENMDVEIWTKEGERKKLRPRWLDARTYSDPLALREFKEFAAGRRSVSGDLILEIGKLPQHLTQRAQNALDNLVMLHNSEQGGRAYRHAMEELPDTIETLMLLALIAVLTGGVTLFFLSGRGLGKTSIGLLCVMASSVLLWMASVEPHWIAASIILEFFLMVLLIPEPDRQRTPQDNQLAYVVIGLLFMILTVAANEMGLLETTKKDLGIGHVAVENHHHATMLDVDLHPASAWTLYAVATTIITPMMRHTIENTTANISLTAIANQAAILMGLDKGWPISKMDIGVPLLALGCYSQVNPLTLTAAVLMLVAHYAIIGPGLQAKATREAQKRTAAGIMKNPTVDGIVAIDLDPVVYDAKFEKQLGQIMLLILCTSQILLMRTTWALCESITLATGPLTTLWEGSPGKFRNTTIAVSMANIFRGSYLAGAGLAFSLMKSLGGGRRGTGAQGETLGEKWKRQLNQLSKSEFNTYKRSGIMEVDRSEAKEGLKRGETTKHAVSRGTAKLRWFVERNLVKPEGKVIDLGCGRGGWSYYCAGLKKVTEVKGYTKGGPGHEEPIPMATYGWNLVKLYSGKDVFFIPPEKCDTLLCDIGESSPNPTIEEGRTLRVLKMVEPWLRGNQFCIKILNPYMPSEVETLEQMQRRHGGMLVRNPLSRNSTHEMYWVSCGTGNIVSAVNMTSRMLLNRFTMAHRKPTYERDVDLGAGTRHVAVEPEVANLDIIGQRIENIKHEHKSTWHYDEDNPYKTWAYHGSYEVKPSGSASSMVNGVVKLLTKPWDVIPMVTQIAMTDTTPFGQQRVFKEKVDTRTPKAKRGTAQIMEVTARWLWGFLSRNKKPRICTREEFTRKVRSNAAIGAVFIDENQWNSAKEAVEDERFWDLVHRERELHKQGKCATCVYNMMGKREKKLGEFGKAKGSRAIWYMWLGARFLEFEALGFMNEDHWFSRENSLSGVEGEGLHKLGYILRDISKIPGGNMYADDTAGWDTRITEDDLQNEAKITDIMEPEHALLAKAIFKLTYQNKVVRVQRPAKNGTVMDVISRRDQRGSGQVGTYGLNTFTNMEAQLIRQMESEGIFSPSELETPNLAERVLDWLEKYGVERLKRMAISGDDCVVKPIDDRFATALTALNDMGKVRKDIPQWEPSKGWNDWQQVPFCSHHFHQLIMKDGREIVVPCRNQDELVGRARVSQGAGWSLRETACLGKSYAQMWQLMYFHRRDLRLAANAICSAVPVDWVPTSRTTWSIHAHHQWMTTEDMLSVWNRVWIEENPWMEDKTHISSWEDVPYLGKREDQWCGSLIGLTARATWATNIQVAINQVRRLIGNENYLDYMTSMKRFKNESDPEGALW";
            string stn = "QCETESYKQLVANVDKLEAL";
            int like = 0;
            List<int> rank = new List<int>();
            char[] text1 = str.ToCharArray();
            char[] text2 = stn.ToCharArray();
            bool pri = true;
            char[] anterior = new char[2];

            for (int y = 0; y < text2.Length; y++)
            {
                anterior[0] = text2[y];
                text2[y] = '*';

                for (int t = y + 1; t < text2.Length; t++)
                {
                    anterior[1] = text2[t];
                    text2[t] = '*';

                    for (int i = 0; i < text1.Length; i++)
                    {
                        int x = i;
                        for (int j = 0; j < text2.Length; j++)
                        {
                            Console.Write(text2[j].ToString());
                            if (pri)
                            {
                                if (text2[j] != '*')

                                    if (text1[j] == text2[j])
                                    {
                                        like++;
                                    }
                            }
                            else
                            {
                                if (x <= text1.Length - 1)
                                {
                                    if (text2[j] != '*')
                                        if (text1[x] == text2[j])
                                        {
                                            like++;
                                        }
                                }
                                x++;
                            }
                        }
                        Console.WriteLine();
                        rank.Add(like);
                        like = 0;
                        pri = false;
                    }
                    text2[t] = anterior[1];
                }
                text2[y] = anterior[0];
            }
            var list = rank.OrderByDescending(x => x);

            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.Read();
        }

        private static void CompararStrs()
        {
            List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
            List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
            EpitopeDAO epitopeDAO = new EpitopeDAO();
            List<object> listMath = new List<object>();
            TranslationsDAO translationsDAO = new TranslationsDAO();
            lstEpi = epitopeDAO.Epitopes();
            lstTrans = translationsDAO.Listar();
            int contador = 0;

            foreach (EpitopeDTO item in lstEpi)
            {
                foreach (SequenceTranslationDTO item2 in lstTrans)
                {
                    contador = 0;
                    for (int i = 0; i < item.LinearSequence.Length; i++)
                    {
                        if (item2.Translation.IndexOf(item.LinearSequence) != -1)
                        {
                            Console.WriteLine("Eu sou igual");
                        }
                        if (item2.Translation.IndexOf(item.LinearSequence) == -1)
                        {
                            Console.WriteLine("Imprementar para verificar se não validar posições");
                        }
                        //item2.Translation.IndexOf(item.LinearSequence));

                        //if (item2.Translation.IndexOf(item.LinearSequence[i].ToString()) > 0)
                        //if (item2.Translation.Contains(item.LinearSequence[i].ToString()))
                        //{
                        //    contador++;
                        //    Console.Write(item.LinearSequence[i]);
                        //}
                    }
                    Console.WriteLine();
                }





                //foreach (EpitopeDTO item in lstEpi)
                //{
                //    foreach (SequenceTranslationDTO item2 in lstTrans)
                //    {
                //        contador = 0;
                //        int i = 0;
                //        while (contador <= 2 || i < item.LinearSequence.Length)
                //        {
                //            if (!item2.Translation.Contains(item.LinearSequence[i].ToString()))
                //            {
                //                contador++;
                //            }
                //            i++;
                //        }
                //        if (contador == 0)
                //        {

                //        }
                //        else if (contador == 1)
                //        {

                //        }
                //        else
                //        {

                //        }

                //        Console.Write("  Tamanho Total: " + item.LinearSequence.Length + " Encontrados: " + contador);
                //        Console.WriteLine();
                //    }
                //}

                Console.Read();
            }
        }
        /// <summary>
        /// Metodo faz a comparação sem levar em consideração alguma mutação 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public void SlideWindow(string strMaior, string strMenor)
        {

            string str = "Vai tomar no cu";
            string stn = "mar";
            int like = 0;
            List<int> rank = new List<int>();
            char[] text1 = str.ToCharArray();
            char[] text2 = stn.ToCharArray();
            bool pri = true;

            for (int i = 0; i < text1.Length; i++)
            {
                int x = i;
                for (int j = 0; j < text2.Length; j++)
                {

                    if (pri)
                    {
                        if (text1[j] == text2[j])
                        {
                            like++;
                        }
                    }
                    else
                    {
                        if (x <= text1.Length - 1)
                        {
                            if (text1[x] == text2[j])
                            {
                                like++;
                            }

                        }
                        x++;
                    }
                }
                rank.Add(like);
                like = 0;
                pri = false;
            }

        }

        /// <summary>
        /// Metodo faz a comparação levando em consideração uma mutação. 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public void CompararLevandoUmaAlteracao(string strMaior, string strMenor)
        {
            int like = 0;
            List<int> rank = new List<int>();
            char[] text1 = strMaior.ToCharArray();
            char[] text2 = strMenor.ToCharArray();
            bool pri = true;
            char[] anterior = new char[2];

            for (int t = 0 + 1; t < text2.Length; t++)
            {
                anterior[0] = text2[t];
                text2[t] = '*';

                for (int i = 0; i < text1.Length; i++)
                {
                    int x = i;
                    for (int j = 0; j < text2.Length; j++)
                    {
                        Console.Write(text2[j].ToString());
                        if (pri)
                        {
                            if (text2[j] != '*')

                                if (text1[j] == text2[j])
                                {
                                    like++;
                                }
                        }
                        else
                        {
                            if (x <= text1.Length - 1)
                            {
                                if (text2[j] != '*')
                                    if (text1[x] == text2[j])
                                    {
                                        like++;
                                    }
                            }
                            x++;
                        }
                    }
                    Console.WriteLine();
                    rank.Add(like);
                    like = 0;
                    pri = false;
                }
                text2[t] = anterior[0];
            }
        }

        public void CompararDuasMutacoes(string strMaior, string strMenor)
        {

            char[] text1 = strMaior.ToCharArray();
            char[] text2 = strMenor.ToCharArray();
            bool pri = true;
            char[] anterior = new char[2];

            for (int y = 0; y < text2.Length; y++)
            {
                anterior[0] = text2[y];
                text2[y] = '*';

                for (int t = y + 1; t < text2.Length; t++)
                {
                    anterior[1] = text2[t];
                    text2[t] = '*';

                    for (int i = 0; i < text1.Length; i++)
                    {
                        int x = i;
                        for (int j = 0; j < text2.Length; j++)
                        {
                            Console.Write(text2[j].ToString());
                            if (pri)
                            {
                                if (text2[j] != '*')

                                    if (text1[j] == text2[j])
                                    {
                                        like++;
                                    }
                            }
                            else
                            {
                                if (x <= text1.Length - 1)
                                {
                                    if (text2[j] != '*')
                                        if (text1[x] == text2[j])
                                        {
                                            like++;
                                        }
                                }
                                x++;
                            }
                        }
                        Console.WriteLine();
                        rank.Add(like);
                        like = 0;
                        pri = false;
                    }
                    text2[t] = anterior[1];
                }
                text2[y] = anterior[0];
            }
        }

    }
}