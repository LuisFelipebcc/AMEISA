using AMEISA.DAO;
using AMEISA.Model;
using System;
using System.Collections.Generic;

namespace AMEISA
{
    class Program
    {
        static int like = 0;
        static int score = 0;
        static bool pri = true;
        static char[] anterior = new char[2];
        static RanqueEpitoposDTO objRanqueEpitoposDTO = new RanqueEpitoposDTO();

        static List<RanqueEpitoposDTO> MappingWithoutMutation = new List<RanqueEpitoposDTO>();
        static List<RanqueEpitoposDTO> MappingWithAMutation = new List<RanqueEpitoposDTO>();
        static List<RanqueEpitoposDTO> MappingWithTwoMutation = new List<RanqueEpitoposDTO>();



        static void Main(string[] args)
        {

            CompararStrs();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Sem Mutação                  ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations ===    Hit    ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithoutMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Hit);
            }

            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Com 1 Mutação                ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations ===    Hit    ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithAMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Hit);
            }

            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Com 2 Mutação                ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations ===    Hit    ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithTwoMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Hit);
            }

            Console.WriteLine("====================================================");


            Console.Read();
        }

        private static void CompararStrs()
        {
            //string str = "MNNQRKKTARPSFNMLKRARNRVSTVSQLAKRFSKGLLSGQGPMKLVMAFIAFLRFLAIPPTAGILARWGSFKKNGAIKVLRGFKKEISSMLNIMNRRKRSVTMLLMLMPTALAFHLTTRGGEPHMIVSKQERGKSLLFKTSAGVNMCTLIAMDLGELCEDTMTYKCPRITEAEPDDVDCWCNATDTWVTYGTCSQTGEHRRDKRSVALAPHVGLGLETRTETWMSSEGAWKQIQRVETWALRHPGFTVIALFLAHAIGTSITQKGIIFILLMLVTPSMAMRCVGIGSRDFVEGLSGATWVDVVLEHGSCVTTMAKDKPTLDIELLKTEVTNPAVLRKLCIEAKISNTTTDSRCPTQGEATLVEEQDANFVCRRTFVDRGWGNGCGLFGKGSLITCAKFKCVTKLEGKIVQYENLKYSVIVTVHTGDQHQVGNESTEHGTTATITPQAPTTEIQLTDYGALTLDCSPRTGLDFNEMVLLTMKEKSWLVHKQWFLDLPLPWTSGASTSQETWNRQDLLVTFKTAHAKKQEVVVLGSQEGAMHTALTGATEIQTSGTTTIFAGHLKCRLKMDKLTLKGMSYVMCTGSFKLEKEVAETQHGTVLVQIKYEGTDAPCKIPFSTQDEKGVTQNGRLITANPIVTDKEKPVNIEAEPPFGESHIVIGAGEKALKLSWFKKGSSIGKMFEATARGARRMAILGDTAWDFGSIGGVFTSVGKLVHQIFGTAYGVLFSGVSWTMKIGIGVLLTWLGLNSRSTSLSMTCIAVGLVTLYLGVMVQADSGCVINWKGRELKCGSGIFVTNEVHTWTEQYKFQADSPKRLSAAIGKAWEEGVCGIRSATRLENIMWKQISNELNHILLENDMKFTVVVGDVAGILAQGKKMISPQPMEHKYSWKSWGKAKIIGADVQNTTFIIDGPNTPECPDDQRAWNIWEVEDYGFGIFTTNIWLKLRDSYTQVCDHRLMSAAIKDSKAVHADMGYWIESEKNETWKLARASFIEVKTCIWPKSHTLWSNGVLESEMIIPKIYGGPISQHNYRPGYFTQTAGPWHLGKLELDFDLCEGTTVVVDEHCGSRGPSLRTTTVTGKIIHEWCCRSCTLPPLRFRGEDGCWYGMEIRPVKEKEENLVKSMVSAGSGEVDSFSLGLLCISIMIEEVMRSRWSRKMLMTGTLAVFFLLIMGQLTWNDLIRLCIMVGANASDRMGMGTTYLALMATFKMRPMFAVGLLFRRLTSREVLLLTIGLSLVASVELPNSLEELGDGLAMGIMILKLLTDFQSHQLWATLLSLTFIKTTFSLHYAWKTVAMVLSIVSLFPLCLSTTSQKTTWLPVLLGSLGCKPLTMFLIAENKIWGRKSWPLNEGIMAVGIVSILLSSLLKNDVPLAGPLIAGGMLIACYDMSGSSADLSLEKAAEVSWEEEAEHSGASHNILVEVQDDGTMKIKDEERDDTLTILLKATLLAISGVYPLSIPATLFVWYFWQKKKQRSGVLWDTPSPPEVERAVLDDGIYRIMQRGLLGRSQVGVGVFQENVFHTMWHVTRGAVLMYQGKRLEPSWASVKKDLISYGGGWRLQGSWNTGEEVQVIAVEPGKNPKNVQTAPGTFKTPEGEVGAIALDFKPGTSGSPIVNREGKIVGLYGNGVVTTSGTYVSAIAQAKASQEGPLPEIEDEVFRKRNLTIMDLHPGSGKTRRYLPAIVREAIKRKLRTLILAPTRVVASEMAEALKGMPIRYQTTAVKSEHTGKEIVDLMCHATFTMRLLSPVRVPNYNMIIMDEAHFTDPSSIAARGYISTRVGMGEAAAIFMTATPPGSVEAFPQSNAVIQDEERDIPERSWNSGYEWITDFPGKTVWFVPSIKSGNDIANCLRKNGKRVIQLSRKTFDTEYQKTKNNDWDYVVTTDISEMGANFRADRVIDPRRCLKPVILKDGPERVILAGPMPVTVASAAQRRGRIGRNHNKEGDQYIYMGQPLNNDEDHAHWTEAKMLLDNINTPEGIIPALFEPEREKSAAIDGEYRLRGEARKTFVELMRRGDLPVWLSYKVASEGFQYSDRRWCFDGERNNQVLEENMDVEIWTKEGERKKLRPRWLDARTYSDPLALREFKEFAAGRRSVSGDLILEIGKLPQHLTQRAQNALDNLVMLHNSEQGGRAYRHAMEELPDTIETLMLLALIAVLTGGVTLFFLSGRGLGKTSIGLLCVMASSVLLWMASVEPHWIAASIILEFFLMVLLIPEPDRQRTPQDNQLAYVVIGLLFMILTVAANEMGLLETTKKDLGIGHVAVENHHHATMLDVDLHPASAWTLYAVATTIITPMMRHTIENTTANISLTAIANQAAILMGLDKGWPISKMDIGVPLLALGCYSQVNPLTLTAAVLMLVAHYAIIGPGLQAKATREAQKRTAAGIMKNPTVDGIVAIDLDPVVYDAKFEKQLGQIMLLILCTSQILLMRTTWALCESITLATGPLTTLWEGSPGKFRNTTIAVSMANIFRGSYLAGAGLAFSLMKSLGGGRRGTGAQGETLGEKWKRQLNQLSKSEFNTYKRSGIMEVDRSEAKEGLKRGETTKHAVSRGTAKLRWFVERNLVKPEGKVIDLGCGRGGWSYYCAGLKKVTEVKGYTKGGPGHEEPIPMATYGWNLVKLYSGKDVFFIPPEKCDTLLCDIGESSPNPTIEEGRTLRVLKMVEPWLRGNQFCIKILNPYMPSEVETLEQMQRRHGGMLVRNPLSRNSTHEMYWVSCGTGNIVSAVNMTSRMLLNRFTMAHRKPTYERDVDLGAGTRHVAVEPEVANLDIIGQRIENIKHEHKSTWHYDEDNPYKTWAYHGSYEVKPSGSASSMVNGVVKLLTKPWDVIPMVTQIAMTDTTPFGQQRVFKEKVDTRTPKAKRGTAQIMEVTARWLWGFLSRNKKPRICTREEFTRKVRSNAAIGAVFIDENQWNSAKEAVEDERFWDLVHRERELHKQGKCATCVYNMMGKREKKLGEFGKAKGSRAIWYMWLGARFLEFEALGFMNEDHWFSRENSLSGVEGEGLHKLGYILRDISKIPGGNMYADDTAGWDTRITEDDLQNEAKITDIMEPEHALLAKAIFKLTYQNKVVRVQRPAKNGTVMDVISRRDQRGSGQVGTYGLNTFTNMEAQLIRQMESEGIFSPSELETPNLAERVLDWLEKYGVERLKRMAISGDDCVVKPIDDRFATALTALNDMGKVRKDIPQWEPSKGWNDWQQVPFCSHHFHQLIMKDGREIVVPCRNQDELVGRARVSQGAGWSLRETACLGKSYAQMWQLMYFHRRDLRLAANAICSAVPVDWVPTSRTTWSIHAHHQWMTTEDMLSVWNRVWIEENPWMEDKTHISSWEDVPYLGKREDQWCGSLIGLTARATWATNIQVAINQVRRLIGNENYLDYMTSMKRFKNESDPEGALW";
            //string stn = "QCETESYKQLVANVDKLEAL";
            string stn = "GWGNGCGLF";
            string stn1 = "GKAKGSRAIWYMWLG";

            List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
            List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
            lstEpi.Add(new EpitopeDTO()
            {
                IdEpitope = 1,
                LinearSequence = stn
            });
            lstEpi.Add(new EpitopeDTO()
            {
                IdEpitope = 2,
                LinearSequence = stn1
            });


            EpitopeDAO epitopeDAO = new EpitopeDAO();
            List<object> listMath = new List<object>();
            TranslationsDAO translationsDAO = new TranslationsDAO();
            lstTrans = translationsDAO.Listar();

            foreach (EpitopeDTO item in lstEpi)
            {
                foreach (SequenceTranslationDTO item2 in lstTrans)
                {
                    CompararSemMutacao(item2, item);
                    CompararLevandoUmaAlteracao(item2, item);
                    CompararDuasMutacoes(item2, item);
                }

            }

        }

        /// <summary>
        /// Metodo faz a comparação sem levar em consideração alguma mutação 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void CompararSemMutacao(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
        {
            char[] text1 = strMaior.Translation.ToCharArray();
            char[] text2 = strMenor.LinearSequence.ToCharArray();

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
                score = like == strMenor.LinearSequence.Length ? score++ : score;
                like = 0;
                pri = false;
            }
            MappingWithoutMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = strMenor.IdEpitope,
                IdTranslations = strMaior.IdSequence,
                Hit = score
            });
            score = 0;
        }

        /// <summary>
        /// Metodo faz a comparação levando em consideração uma mutação. 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void CompararLevandoUmaAlteracao(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
        {
            score = 0;
            char[] text1 = strMaior.Translation.ToCharArray();
            char[] text2 = strMenor.LinearSequence.ToCharArray();

            for (int t = 0; t < text2.Length; t++)
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
                    score = like == strMenor.LinearSequence.Length ? score++ : score;
                    like = 0;
                    pri = false;
                }
                text2[t] = anterior[0];
            }
            MappingWithAMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = 1,
                IdTranslations = 1,
                Hit = score
            });
        }

        /// <summary>
        /// Metodo faz a comparação levando em consideração duas mutações. 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void CompararDuasMutacoes(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
        {
            score = 0;
            char[] text1 = strMaior.Translation.ToCharArray();
            char[] text2 = strMenor.LinearSequence.ToCharArray();

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
                        score = like == strMenor.LinearSequence.Length ? score++ : score;
                        like = 0;
                        pri = false;
                    }
                    text2[t] = anterior[1];
                }
                text2[y] = anterior[0];
            }
            MappingWithTwoMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = strMenor.IdEpitope,
                IdTranslations = strMaior.IdSequence,
                Hit = score
            });
        }

    }
}