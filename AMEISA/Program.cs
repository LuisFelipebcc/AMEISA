using AMEISA.DAO;
using AMEISA.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
            string str = "MNNQRKKTARPSFNMLKRARNRVSTVSQLAKRFSKGLLSGQGPMKLVMAFIAFLRFLAIPPTAGILARWGSFKKNGAIKVLRGFKKEISSMLNIMNRRKRSVTMLLMLMPTALAFHLTTRGGEPHMIVSKQERGKSLLFKTSAGVNMCTLIAMDLGELCEDTMTYKCPRITEAEPDDVDCWCNATDTWVTYGTCSQTGEHRRDKRSVALAPHVGLGLETRTETWMSSEGAWKQIQRVETWALRHPGFTVIALFLAHAIGTSITQKGIIFILLMLVTPSMAMRCVGIGSRDFVEGLSGATWVDVVLEHGSCVTTMAKDKPTLDIELLKTEVTNPAVLRKLCIEAKISNTTTDSRCPTQGEATLVEEQDANFVCRRTFVDRGWGNGCGLFGKGSLITCAKFKCVTKLEGKIVQYENLKYSVIVTVHTGDQHQVGNESTEHGTTATITPQAPTTEIQLTDYGALTLDCSPRTGLDFNEMVLLTMKEKSWLVHKQWFLDLPLPWTSGASTSQETWNRQDLLVTFKTAHAKKQEVVVLGSQEGAMHTALTGATEIQTSGTTTIFAGHLKCRLKMDKLTLKGMSYVMCTGSFKLEKEVAETQHGTVLVQIKYEGTDAPCKIPFSTQDEKGVTQNGRLITANPIVTDKEKPVNIEAEPPFGESHIVIGAGEKALKLSWFKKGSSIGKMFEATARGARRMAILGDTAWDFGSIGGVFTSVGKLVHQIFGTAYGVLFSGVSWTMKIGIGVLLTWLGLNSRSTSLSMTCIAVGLVTLYLGVMVQADSGCVINWKGRELKCGSGIFVTNEVHTWTEQYKFQADSPKRLSAAIGKAWEEGVCGIRSATRLENIMWKQISNELNHILLENDMKFTVVVGDVAGILAQGKKMISPQPMEHKYSWKSWGKAKIIGADVQNTTFIIDGPNTPECPDDQRAWNIWEVEDYGFGIFTTNIWLKLRDSYTQVCDHRLMSAAIKDSKAVHADMGYWIESEKNETWKLARASFIEVKTCIWPKSHTLWSNGVLESEMIIPKIYGGPISQHNYRPGYFTQTAGPWHLGKLELDFDLCEGTTVVVDEHCGSRGPSLRTTTVTGKIIHEWCCRSCTLPPLRFRGEDGCWYGMEIRPVKEKEENLVKSMVSAGSGEVDSFSLGLLCISIMIEEVMRSRWSRKMLMTGTLAVFFLLIMGQLTWNDLIRLCIMVGANASDRMGMGTTYLALMATFKMRPMFAVGLLFRRLTSREVLLLTIGLSLVASVELPNSLEELGDGLAMGIMILKLLTDFQSHQLWATLLSLTFIKTTFSLHYAWKTVAMVLSIVSLFPLCLSTTSQKTTWLPVLLGSLGCKPLTMFLIAENKIWGRKSWPLNEGIMAVGIVSILLSSLLKNDVPLAGPLIAGGMLIACYDMSGSSADLSLEKAAEVSWEEEAEHSGASHNILVEVQDDGTMKIKDEERDDTLTILLKATLLAISGVYPLSIPATLFVWYFWQKKKQRSGVLWDTPSPPEVERAVLDDGIYRIMQRGLLGRSQVGVGVFQENVFHTMWHVTRGAVLMYQGKRLEPSWASVKKDLISYGGGWRLQGSWNTGEEVQVIAVEPGKNPKNVQTAPGTFKTPEGEVGAIALDFKPGTSGSPIVNREGKIVGLYGNGVVTTSGTYVSAIAQAKASQEGPLPEIEDEVFRKRNLTIMDLHPGSGKTRRYLPAIVREAIKRKLRTLILAPTRVVASEMAEALKGMPIRYQTTAVKSEHTGKEIVDLMCHATFTMRLLSPVRVPNYNMIIMDEAHFTDPSSIAARGYISTRVGMGEAAAIFMTATPPGSVEAFPQSNAVIQDEERDIPERSWNSGYEWITDFPGKTVWFVPSIKSGNDIANCLRKNGKRVIQLSRKTFDTEYQKTKNNDWDYVVTTDISEMGANFRADRVIDPRRCLKPVILKDGPERVILAGPMPVTVASAAQRRGRIGRNHNKEGDQYIYMGQPLNNDEDHAHWTEAKMLLDNINTPEGIIPALFEPEREKSAAIDGEYRLRGEARKTFVELMRRGDLPVWLSYKVASEGFQYSDRRWCFDGERNNQVLEENMDVEIWTKEGERKKLRPRWLDARTYSDPLALREFKEFAAGRRSVSGDLILEIGKLPQHLTQRAQNALDNLVMLHNSEQGGRAYRHAMEELPDTIETLMLLALIAVLTGGVTLFFLSGRGLGKTSIGLLCVMASSVLLWMASVEPHWIAASIILEFFLMVLLIPEPDRQRTPQDNQLAYVVIGLLFMILTVAANEMGLLETTKKDLGIGHVAVENHHHATMLDVDLHPASAWTLYAVATTIITPMMRHTIENTTANISLTAIANQAAILMGLDKGWPISKMDIGVPLLALGCYSQVNPLTLTAAVLMLVAHYAIIGPGLQAKATREAQKRTAAGIMKNPTVDGIVAIDLDPVVYDAKFEKQLGQIMLLILCTSQILLMRTTWALCESITLATGPLTTLWEGSPGKFRNTTIAVSMANIFRGSYLAGAGLAFSLMKSLGGGRRGTGAQGETLGEKWKRQLNQLSKSEFNTYKRSGIMEVDRSEAKEGLKRGETTKHAVSRGTAKLRWFVERNLVKPEGKVIDLGCGRGGWSYYCAGLKKVTEVKGYTKGGPGHEEPIPMATYGWNLVKLYSGKDVFFIPPEKCDTLLCDIGESSPNPTIEEGRTLRVLKMVEPWLRGNQFCIKILNPYMPSEVETLEQMQRRHGGMLVRNPLSRNSTHEMYWVSCGTGNIVSAVNMTSRMLLNRFTMAHRKPTYERDVDLGAGTRHVAVEPEVANLDIIGQRIENIKHEHKSTWHYDEDNPYKTWAYHGSYEVKPSGSASSMVNGVVKLLTKPWDVIPMVTQIAMTDTTPFGQQRVFKEKVDTRTPKAKRGTAQIMEVTARWLWGFLSRNKKPRICTREEFTRKVRSNAAIGAVFIDENQWNSAKEAVEDERFWDLVHRERELHKQGKCATCVYNMMGKREKKLGEFGKAKGSRAIWYMWLGARFLEFEALGFMNEDHWFSRENSLSGVEGEGLHKLGYILRDISKIPGGNMYADDTAGWDTRITEDDLQNEAKITDIMEPEHALLAKAIFKLTYQNKVVRVQRPAKNGTVMDVISRRDQRGSGQVGTYGLNTFTNMEAQLIRQMESEGIFSPSELETPNLAERVLDWLEKYGVERLKRMAISGDDCVVKPIDDRFATALTALNDMGKVRKDIPQWEPSKGWNDWQQVPFCSHHFHQLIMKDGREIVVPCRNQDELVGRARVSQGAGWSLRETACLGKSYAQMWQLMYFHRRDLRLAANAICSAVPVDWVPTSRTTWSIHAHHQWMTTEDMLSVWNRVWIEENPWMEDKTHISSWEDVPYLGKREDQWCGSLIGLTARATWATNIQVAINQVRRLIGNENYLDYMTSMKRFKNESDPEGALW";
            string stn = "QCETESYKQLVANVDKLEAL";

            //string str = "VAI TOMAR NO CU";
            //string stn = "MAR";

            //Comparar(str, stn);
            //CompararLevandoUmaAlteracao(str, stn);
            //CompararDuasMutacoes(str, stn);


            CompararStrs();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Sem Mutação                  ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations === Pontuação ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithoutMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Pontuacao);
            }

            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Com 1 Mutação                ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations === Pontuação ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithAMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Pontuacao);
            }

            Console.WriteLine("====================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("====================================================");
            Console.WriteLine("===                 Com 2 Mutação                ===");
            Console.WriteLine("====================================================");
            Console.WriteLine("=== ID_Epitopo === ID_Translations === Pontuação ===");
            Console.WriteLine("====================================================");

            foreach (var item in MappingWithTwoMutation)
            {
                Console.WriteLine("===    {0}     ===       {1}       ===     {2}   ===", item.IdEpitopo, item.IdTranslations, item.Pontuacao);
            }

            Console.WriteLine("====================================================");


            Console.Read();
        }

        private static void CompararStrs()
        {
            string str = "MNNQRKKTARPSFNMLKRARNRVSTVSQLAKRFSKGLLSGQGPMKLVMAFIAFLRFLAIPPTAGILARWGSFKKNGAIKVLRGFKKEISSMLNIMNRRKRSVTMLLMLMPTALAFHLTTRGGEPHMIVSKQERGKSLLFKTSAGVNMCTLIAMDLGELCEDTMTYKCPRITEAEPDDVDCWCNATDTWVTYGTCSQTGEHRRDKRSVALAPHVGLGLETRTETWMSSEGAWKQIQRVETWALRHPGFTVIALFLAHAIGTSITQKGIIFILLMLVTPSMAMRCVGIGSRDFVEGLSGATWVDVVLEHGSCVTTMAKDKPTLDIELLKTEVTNPAVLRKLCIEAKISNTTTDSRCPTQGEATLVEEQDANFVCRRTFVDRGWGNGCGLFGKGSLITCAKFKCVTKLEGKIVQYENLKYSVIVTVHTGDQHQVGNESTEHGTTATITPQAPTTEIQLTDYGALTLDCSPRTGLDFNEMVLLTMKEKSWLVHKQWFLDLPLPWTSGASTSQETWNRQDLLVTFKTAHAKKQEVVVLGSQEGAMHTALTGATEIQTSGTTTIFAGHLKCRLKMDKLTLKGMSYVMCTGSFKLEKEVAETQHGTVLVQIKYEGTDAPCKIPFSTQDEKGVTQNGRLITANPIVTDKEKPVNIEAEPPFGESHIVIGAGEKALKLSWFKKGSSIGKMFEATARGARRMAILGDTAWDFGSIGGVFTSVGKLVHQIFGTAYGVLFSGVSWTMKIGIGVLLTWLGLNSRSTSLSMTCIAVGLVTLYLGVMVQADSGCVINWKGRELKCGSGIFVTNEVHTWTEQYKFQADSPKRLSAAIGKAWEEGVCGIRSATRLENIMWKQISNELNHILLENDMKFTVVVGDVAGILAQGKKMISPQPMEHKYSWKSWGKAKIIGADVQNTTFIIDGPNTPECPDDQRAWNIWEVEDYGFGIFTTNIWLKLRDSYTQVCDHRLMSAAIKDSKAVHADMGYWIESEKNETWKLARASFIEVKTCIWPKSHTLWSNGVLESEMIIPKIYGGPISQHNYRPGYFTQTAGPWHLGKLELDFDLCEGTTVVVDEHCGSRGPSLRTTTVTGKIIHEWCCRSCTLPPLRFRGEDGCWYGMEIRPVKEKEENLVKSMVSAGSGEVDSFSLGLLCISIMIEEVMRSRWSRKMLMTGTLAVFFLLIMGQLTWNDLIRLCIMVGANASDRMGMGTTYLALMATFKMRPMFAVGLLFRRLTSREVLLLTIGLSLVASVELPNSLEELGDGLAMGIMILKLLTDFQSHQLWATLLSLTFIKTTFSLHYAWKTVAMVLSIVSLFPLCLSTTSQKTTWLPVLLGSLGCKPLTMFLIAENKIWGRKSWPLNEGIMAVGIVSILLSSLLKNDVPLAGPLIAGGMLIACYDMSGSSADLSLEKAAEVSWEEEAEHSGASHNILVEVQDDGTMKIKDEERDDTLTILLKATLLAISGVYPLSIPATLFVWYFWQKKKQRSGVLWDTPSPPEVERAVLDDGIYRIMQRGLLGRSQVGVGVFQENVFHTMWHVTRGAVLMYQGKRLEPSWASVKKDLISYGGGWRLQGSWNTGEEVQVIAVEPGKNPKNVQTAPGTFKTPEGEVGAIALDFKPGTSGSPIVNREGKIVGLYGNGVVTTSGTYVSAIAQAKASQEGPLPEIEDEVFRKRNLTIMDLHPGSGKTRRYLPAIVREAIKRKLRTLILAPTRVVASEMAEALKGMPIRYQTTAVKSEHTGKEIVDLMCHATFTMRLLSPVRVPNYNMIIMDEAHFTDPSSIAARGYISTRVGMGEAAAIFMTATPPGSVEAFPQSNAVIQDEERDIPERSWNSGYEWITDFPGKTVWFVPSIKSGNDIANCLRKNGKRVIQLSRKTFDTEYQKTKNNDWDYVVTTDISEMGANFRADRVIDPRRCLKPVILKDGPERVILAGPMPVTVASAAQRRGRIGRNHNKEGDQYIYMGQPLNNDEDHAHWTEAKMLLDNINTPEGIIPALFEPEREKSAAIDGEYRLRGEARKTFVELMRRGDLPVWLSYKVASEGFQYSDRRWCFDGERNNQVLEENMDVEIWTKEGERKKLRPRWLDARTYSDPLALREFKEFAAGRRSVSGDLILEIGKLPQHLTQRAQNALDNLVMLHNSEQGGRAYRHAMEELPDTIETLMLLALIAVLTGGVTLFFLSGRGLGKTSIGLLCVMASSVLLWMASVEPHWIAASIILEFFLMVLLIPEPDRQRTPQDNQLAYVVIGLLFMILTVAANEMGLLETTKKDLGIGHVAVENHHHATMLDVDLHPASAWTLYAVATTIITPMMRHTIENTTANISLTAIANQAAILMGLDKGWPISKMDIGVPLLALGCYSQVNPLTLTAAVLMLVAHYAIIGPGLQAKATREAQKRTAAGIMKNPTVDGIVAIDLDPVVYDAKFEKQLGQIMLLILCTSQILLMRTTWALCESITLATGPLTTLWEGSPGKFRNTTIAVSMANIFRGSYLAGAGLAFSLMKSLGGGRRGTGAQGETLGEKWKRQLNQLSKSEFNTYKRSGIMEVDRSEAKEGLKRGETTKHAVSRGTAKLRWFVERNLVKPEGKVIDLGCGRGGWSYYCAGLKKVTEVKGYTKGGPGHEEPIPMATYGWNLVKLYSGKDVFFIPPEKCDTLLCDIGESSPNPTIEEGRTLRVLKMVEPWLRGNQFCIKILNPYMPSEVETLEQMQRRHGGMLVRNPLSRNSTHEMYWVSCGTGNIVSAVNMTSRMLLNRFTMAHRKPTYERDVDLGAGTRHVAVEPEVANLDIIGQRIENIKHEHKSTWHYDEDNPYKTWAYHGSYEVKPSGSASSMVNGVVKLLTKPWDVIPMVTQIAMTDTTPFGQQRVFKEKVDTRTPKAKRGTAQIMEVTARWLWGFLSRNKKPRICTREEFTRKVRSNAAIGAVFIDENQWNSAKEAVEDERFWDLVHRERELHKQGKCATCVYNMMGKREKKLGEFGKAKGSRAIWYMWLGARFLEFEALGFMNEDHWFSRENSLSGVEGEGLHKLGYILRDISKIPGGNMYADDTAGWDTRITEDDLQNEAKITDIMEPEHALLAKAIFKLTYQNKVVRVQRPAKNGTVMDVISRRDQRGSGQVGTYGLNTFTNMEAQLIRQMESEGIFSPSELETPNLAERVLDWLEKYGVERLKRMAISGDDCVVKPIDDRFATALTALNDMGKVRKDIPQWEPSKGWNDWQQVPFCSHHFHQLIMKDGREIVVPCRNQDELVGRARVSQGAGWSLRETACLGKSYAQMWQLMYFHRRDLRLAANAICSAVPVDWVPTSRTTWSIHAHHQWMTTEDMLSVWNRVWIEENPWMEDKTHISSWEDVPYLGKREDQWCGSLIGLTARATWATNIQVAINQVRRLIGNENYLDYMTSMKRFKNESDPEGALW";
            string stn = "QCETESYKQLVANVDKLEAL";
            List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
            lstEpi.Add(new EpitopeDTO()
            {
                IdEpitope = 1,
                LinearSequence = stn
            });
            List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
            lstTrans.Add(new SequenceTranslationDTO()
            {
                IdSequence = 1,
                Translation = str
            });
            EpitopeDAO epitopeDAO = new EpitopeDAO();
            List<object> listMath = new List<object>();
            TranslationsDAO translationsDAO = new TranslationsDAO();
            //lstEpi = epitopeDAO.Epitopes();
            //lstTrans = translationsDAO.Listar();

            foreach (EpitopeDTO item in lstEpi)
            {
                foreach (SequenceTranslationDTO item2 in lstTrans)
                {
                    //Comparar(item2, item);
                    //CompararLevandoUmaAlteracao(item2, item);
                    CompararDuasMutacoes(item2, item);
                }
                Console.WriteLine();
            }

        }


        /// <summary>
        /// Metodo faz a comparação sem levar em consideração alguma mutação 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void Comparar(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
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
                score = score > like ? score : like;
                like = 0;
                pri = false;
            }
            MappingWithoutMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = strMenor.IdEpitope,
                IdTranslations = strMaior.IdSequence,
                Pontuacao = score
            });
        }

        /// <summary>
        /// Metodo faz a comparação levando em consideração uma mutação. 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void CompararLevandoUmaAlteracao(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
        {
            char[] text1 = strMaior.Translation.ToCharArray();
            char[] text2 = strMenor.LinearSequence.ToCharArray();

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
                    MappingWithAMutation.Add(new RanqueEpitoposDTO()
                    {
                        IdEpitopo = 1,
                        IdTranslations = 1,
                        Pontuacao = like
                    });
                    like = 0;
                    pri = false;
                }
                text2[t] = anterior[0];
            }
        }

        /// <summary>
        /// Metodo faz a comparação levando em consideração duas mutações. 
        /// </summary>
        /// <param name="strMaior">Entrada do translation</param>
        /// <param name="strMenor">Sequence do Epitopo</param>
        public static void CompararDuasMutacoes(SequenceTranslationDTO strMaior, EpitopeDTO strMenor)
        {
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
                        score = score > like ? score : like;
                        like = 0;
                        pri = false;
                    }

                    MappingWithTwoMutation.Add(new RanqueEpitoposDTO()
                    {
                        IdEpitopo = strMenor.IdEpitope,
                        IdTranslations = strMaior.IdSequence,
                        Pontuacao = score
                    });
                    text2[t] = anterior[1];
                }
                text2[y] = anterior[0];
            }
        }

    }
}