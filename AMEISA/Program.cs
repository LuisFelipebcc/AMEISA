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
        static char[] Anterior = new char[2];
        static RanqueEpitoposDTO ObjRanqueEpitoposDTO = new RanqueEpitoposDTO();

        static List<RanqueEpitoposDTO> MappingWithoutMutation = new List<RanqueEpitoposDTO>();
        static List<RanqueEpitoposDTO> MappingWithAMutation = new List<RanqueEpitoposDTO>();
        static List<RanqueEpitoposDTO> MappingWithTwoMutation = new List<RanqueEpitoposDTO>();
        static void Main(string[] args)
        {
            Iniciar();
            //IniciarOutro();

            Console.ReadLine();
        }

        private static void Iniciar()
        {
            //string str = "MNNQRKKTARPSFNMLKRARNRVSTVSQLAKRFSKGLLSGQGPMKLVMAFIAFLRFLAIPPTAGILARWGSFKKNGAIKVLRGFKKEISSMLNIMNRRKRSVTMLLMLMPTALAFHLTTRGGEPHMIVSKQERGKSLLFKTSAGVNMCTLIAMDLGELCEDTMTYKCPRITEAEPDDVDCWCNATDTWVTYGTCSQTGEHRRDKRSVALAPHVGLGLETRTETWMSSEGAWKQIQRVETWALRHPGFTVIALFLAHAIGTSITQKGIIFILLMLVTPSMAMRCVGIGSRDFVEGLSGATWVDVVLEHGSCVTTMAKDKPTLDIELLKTEVTNPAVLRKLCIEAKISNTTTDSRCPTQGEATLVEEQDANFVCRRTFVDRGWGNGCGLFGKGSLITCAKFKCVTKLEGKIVQYENLKYSVIVTVHTGDQHQVGNESTEHGTTATITPQAPTTEIQLTDYGALTLDCSPRTGLDFNEMVLLTMKEKSWLVHKQWFLDLPLPWTSGASTSQETWNRQDLLVTFKTAHAKKQEVVVLGSQEGAMHTALTGATEIQTSGTTTIFAGHLKCRLKMDKLTLKGMSYVMCTGSFKLEKEVAETQHGTVLVQIKYEGTDAPCKIPFSTQDEKGVTQNGRLITANPIVTDKEKPVNIEAEPPFGESHIVIGAGEKALKLSWFKKGSSIGKMFEATARGARRMAILGDTAWDFGSIGGVFTSVGKLVHQIFGTAYGVLFSGVSWTMKIGIGVLLTWLGLNSRSTSLSMTCIAVGLVTLYLGVMVQADSGCVINWKGRELKCGSGIFVTNEVHTWTEQYKFQADSPKRLSAAIGKAWEEGVCGIRSATRLENIMWKQISNELNHILLENDMKFTVVVGDVAGILAQGKKMISPQPMEHKYSWKSWGKAKIIGADVQNTTFIIDGPNTPECPDDQRAWNIWEVEDYGFGIFTTNIWLKLRDSYTQVCDHRLMSAAIKDSKAVHADMGYWIESEKNETWKLARASFIEVKTCIWPKSHTLWSNGVLESEMIIPKIYGGPISQHNYRPGYFTQTAGPWHLGKLELDFDLCEGTTVVVDEHCGSRGPSLRTTTVTGKIIHEWCCRSCTLPPLRFRGEDGCWYGMEIRPVKEKEENLVKSMVSAGSGEVDSFSLGLLCISIMIEEVMRSRWSRKMLMTGTLAVFFLLIMGQLTWNDLIRLCIMVGANASDRMGMGTTYLALMATFKMRPMFAVGLLFRRLTSREVLLLTIGLSLVASVELPNSLEELGDGLAMGIMILKLLTDFQSHQLWATLLSLTFIKTTFSLHYAWKTVAMVLSIVSLFPLCLSTTSQKTTWLPVLLGSLGCKPLTMFLIAENKIWGRKSWPLNEGIMAVGIVSILLSSLLKNDVPLAGPLIAGGMLIACYDMSGSSADLSLEKAAEVSWEEEAEHSGASHNILVEVQDDGTMKIKDEERDDTLTILLKATLLAISGVYPLSIPATLFVWYFWQKKKQRSGVLWDTPSPPEVERAVLDDGIYRIMQRGLLGRSQVGVGVFQENVFHTMWHVTRGAVLMYQGKRLEPSWASVKKDLISYGGGWRLQGSWNTGEEVQVIAVEPGKNPKNVQTAPGTFKTPEGEVGAIALDFKPGTSGSPIVNREGKIVGLYGNGVVTTSGTYVSAIAQAKASQEGPLPEIEDEVFRKRNLTIMDLHPGSGKTRRYLPAIVREAIKRKLRTLILAPTRVVASEMAEALKGMPIRYQTTAVKSEHTGKEIVDLMCHATFTMRLLSPVRVPNYNMIIMDEAHFTDPSSIAARGYISTRVGMGEAAAIFMTATPPGSVEAFPQSNAVIQDEERDIPERSWNSGYEWITDFPGKTVWFVPSIKSGNDIANCLRKNGKRVIQLSRKTFDTEYQKTKNNDWDYVVTTDISEMGANFRADRVIDPRRCLKPVILKDGPERVILAGPMPVTVASAAQRRGRIGRNHNKEGDQYIYMGQPLNNDEDHAHWTEAKMLLDNINTPEGIIPALFEPEREKSAAIDGEYRLRGEARKTFVELMRRGDLPVWLSYKVASEGFQYSDRRWCFDGERNNQVLEENMDVEIWTKEGERKKLRPRWLDARTYSDPLALREFKEFAAGRRSVSGDLILEIGKLPQHLTQRAQNALDNLVMLHNSEQGGRAYRHAMEELPDTIETLMLLALIAVLTGGVTLFFLSGRGLGKTSIGLLCVMASSVLLWMASVEPHWIAASIILEFFLMVLLIPEPDRQRTPQDNQLAYVVIGLLFMILTVAANEMGLLETTKKDLGIGHVAVENHHHATMLDVDLHPASAWTLYAVATTIITPMMRHTIENTTANISLTAIANQAAILMGLDKGWPISKMDIGVPLLALGCYSQVNPLTLTAAVLMLVAHYAIIGPGLQAKATREAQKRTAAGIMKNPTVDGIVAIDLDPVVYDAKFEKQLGQIMLLILCTSQILLMRTTWALCESITLATGPLTTLWEGSPGKFRNTTIAVSMANIFRGSYLAGAGLAFSLMKSLGGGRRGTGAQGETLGEKWKRQLNQLSKSEFNTYKRSGIMEVDRSEAKEGLKRGETTKHAVSRGTAKLRWFVERNLVKPEGKVIDLGCGRGGWSYYCAGLKKVTEVKGYTKGGPGHEEPIPMATYGWNLVKLYSGKDVFFIPPEKCDTLLCDIGESSPNPTIEEGRTLRVLKMVEPWLRGNQFCIKILNPYMPSEVETLEQMQRRHGGMLVRNPLSRNSTHEMYWVSCGTGNIVSAVNMTSRMLLNRFTMAHRKPTYERDVDLGAGTRHVAVEPEVANLDIIGQRIENIKHEHKSTWHYDEDNPYKTWAYHGSYEVKPSGSASSMVNGVVKLLTKPWDVIPMVTQIAMTDTTPFGQQRVFKEKVDTRTPKAKRGTAQIMEVTARWLWGFLSRNKKPRICTREEFTRKVRSNAAIGAVFIDENQWNSAKEAVEDERFWDLVHRERELHKQGKCATCVYNMMGKREKKLGEFGKAKGSRAIWYMWLGARFLEFEALGFMNEDHWFSRENSLSGVEGEGLHKLGYILRDISKIPGGNMYADDTAGWDTRITEDDLQNEAKITDIMEPEHALLAKAIFKLTYQNKVVRVQRPAKNGTVMDVISRRDQRGSGQVGTYGLNTFTNMEAQLIRQMESEGIFSPSELETPNLAERVLDWLEKYGVERLKRMAISGDDCVVKPIDDRFATALTALNDMGKVRKDIPQWEPSKGWNDWQQVPFCSHHFHQLIMKDGREIVVPCRNQDELVGRARVSQGAGWSLRETACLGKSYAQMWQLMYFHRRDLRLAANAICSAVPVDWVPTSRTTWSIHAHHQWMTTEDMLSVWNRVWIEENPWMEDKTHISSWEDVPYLGKREDQWCGSLIGLTARATWATNIQVAINQVRRLIGNENYLDYMTSMKRFKNESDPEGALW";
            //string stn = "GWGNGCGLF";
            string str = "VAI TOMAR NO CU";
            string stn = "MAR";


            //"QCETESYKQLVANVDKLEAL";

            Console.WriteLine(str.IndexOf(stn));
            Console.WriteLine(str.Remove(str.IndexOf(stn), stn.Length));

            //string str = "VAI TOMAR NO CU";
            //string stn = "MAR";

            //Comparar(str, stn);
            //CompararLevandoUmaAlteracao(str, stn);
            //CompararDuasMutacoes(str, stn);

            //CompararStrs();

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
                Anterior[0] = text2[t];
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
                text2[t] = Anterior[0];
            }
            MappingWithAMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = strMenor.IdEpitope,
                IdTranslations = strMaior.IdSequence,
                Pontuacao = score
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
                Anterior[0] = text2[y];
                text2[y] = '*';

                for (int t = y + 1; t < text2.Length; t++)
                {
                    Anterior[1] = text2[t];
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
                    text2[t] = Anterior[1];
                }
                text2[y] = Anterior[0];
            }
            MappingWithTwoMutation.Add(new RanqueEpitoposDTO()
            {
                IdEpitopo = strMenor.IdEpitope,
                IdTranslations = strMaior.IdSequence,
                Hit = score
            });
        }


        /// <summary>
        /// Outro meio de iniciar o algoritmo
        /// </summary>
        public static void IniciarOutro()
        {
            int qtdMutacoes = 2;

            #region Vai vir do banco
            string str = "VAI TOMAR NO CU";
            string stn = "MAR";

            List<EpitopeDTO> lstEpitopos = new List<EpitopeDTO>();
            lstEpitopos.Add(new EpitopeDTO()
            {
                IdEpitope = 1,
                LinearSequence = stn
            });

            List<string> list = new List<string>();
            List<string> lstTrans = list;
            lstTrans.Add(str);
            #endregion

            AjustarRankEpitopos(lstEpitopos, qtdMutacoes);

            foreach (var epi in lstEpitopos)
            {
                foreach (var trans in lstTrans)
                {
                    epi.LstProporcionalRanqueada = CompararDuasStringsPorNumMutacao(trans, epi, qtdMutacoes);
                }
            }

            ExibirResult(lstEpitopos, qtdMutacoes);
        }

        /// <summary>
        /// Vai iniciar a lista de ranking conforme N mutacoes
        /// </summary>
        /// <param name="lstEpi">Lista de epitopos que vira do banco</param>
        /// <param name="qtdMutacoes">Quantidade determinada pelo usuario</param>
        public static void AjustarRankEpitopos(List<EpitopeDTO> lstEpi, int qtdMutacoes)
        {
            foreach (var epi in lstEpi)
            {
                for (int cont = 0; cont <= qtdMutacoes; cont++)
                {
                    epi.LstProporcionalRanqueada.Add(new ProporcaoMutacionalDTO()
                    {
                        NumNivelMutacao = cont,
                        QtdCombinacoes = 0
                    });
                }
            }
        }

        /// <summary>
        /// Metodo para comparar independente do nivel de mutaçõoes 
        /// </summary>
        /// <param name="trans">Entrada do String translation</param>
        /// <param name="epi">Objeto do String Epitopo, o objeto possui mais de uma informação a ser usada aqui</param>
        /// <param name="nivelMaxMutacao">nivel maixmo de mutacao, por ex: "3" a mutacao vai de 0 (nenhuma) a 3 mutacoes</param>
        public static List<ProporcaoMutacionalDTO> CompararDuasStringsPorNumMutacao(string trans, EpitopeDTO epi, int nivelMaxMutacao)
        {
            if (ComparacaoSemMutacao(trans, epi.LinearSequence))
            {
                epi.LstProporcionalRanqueada[0].QtdCombinacoes++;
            }

            for (int cont = 1; cont <= nivelMaxMutacao; cont++)
            {
                if (cont < epi.LinearSequence.Length)
                {
                    if (ComparacaoNMutacoes(trans, epi.LinearSequence, cont))
                    {
                        epi.LstProporcionalRanqueada[cont].QtdCombinacoes++;
                    }
                }
                else
                {
                    epi.LstProporcionalRanqueada[cont].QtdCombinacoes++;
                }
            }

            return epi.LstProporcionalRanqueada;
        }

        /// <summary>
        /// Apenas vai comparar sem mutacoes com index, se encontrar retorna true para adicionar na lista de rank
        /// </summary>
        /// <param name="trans">Entrada do String translation</param>
        /// <param name="epi">Sequence do String Epitopo</param>
        public static Boolean ComparacaoSemMutacao(string trans, string epi)
        {
            if (trans.IndexOf(epi) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para comparar usando especificamente a mutacao determinada no parametro mutação
        /// </summary>
        /// <param name="trans">Entrada do String translation</param>
        /// <param name="epi">Entrada do String Epitopo</param>
        /// <param name="numMutacao">Numero da mutação a ser trabalhada neste momento</param>
        public static Boolean ComparacaoNMutacoes(String trans, String epi, int numMutacao)
        {
            char[] epiOrig = epi.ToCharArray();
            char[] epiMod = epi.ToCharArray();

            for (int cont = 0; cont < numMutacao; cont++)
            {
                epiMod[cont] = '*';
            }

            Boolean finalString = false;
            Boolean encontrouComparacao = false;
            string[] stringSeparators = new string[] { "*" };
            while (!finalString)
            {
                finalString = ChegouFinalString(epiMod, numMutacao);

                String strEpi = new String(epiMod);
                string[] lstStrEpiSeparado = strEpi.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (lstStrEpiSeparado.Length == 1)
                {
                    if (ComparacaoSemMutacao(trans, lstStrEpiSeparado[0]))
                    {
                        return true;
                    }
                }
                else
                {
                    for (int cont = 0; cont < lstStrEpiSeparado.Length - 2; cont++)
                    {
                        if (trans.IndexOf(lstStrEpiSeparado[cont]) + lstStrEpiSeparado[cont].Length + 1 == trans.IndexOf(lstStrEpiSeparado[cont + 1]))
                        {
                            encontrouComparacao = true;
                        }
                    }
                    if (encontrouComparacao)
                    {
                        return true;
                    }
                }

                epiMod = MudarPosicaoMutacoes(epiMod, epiOrig, numMutacao);
            }

            return false;
        }

        /// <summary>
        /// Apenas verifica se chegou no final, ou seja se a quantidade mutações da sequencia, estiver todas no final
        /// É feito uma busta de tras para frente da sequencia, considerando o numedo de mutacoes disponiveis, para poupar tempo
        /// </summary>
        /// <param name="epi">Entrada do char do Epitopo modificado (com mutacoes)</param>
        /// <param name="qtdMutacoes">Quantidade de mutacoes que tem no epitopo modificado</param>
        public static Boolean ChegouFinalString(char[] epiMod, int qtdMutacoes)
        {
            Boolean finalString = true;
            for (int cont = epiMod.Length - 1; cont >= epiMod.Length - qtdMutacoes; cont--)
            {
                if (epiMod[cont] != '*')
                {
                    finalString = false;
                }
            }

            return finalString;
        }

        /// <summary>
        /// Muda as posicoes da mutacao para a proxima posicao, recuperando o caractere, da posicao anterior, original.
        /// É feito uma busta de tras para frente da sequencia, assim que muda uma posicao um break é acionado para interromper o loop
        /// </summary>
        /// <param name="epiMod">Entrada do char do Epitopo modificado (com mutacoes)</param>
        /// <param name="epiOrig">Entrada do char do Epitopo original (sem mutacoes)</param>
        /// <param name="qtdMutacoes">Quantidade de mutacoes que tem no epitopo modificado</param>
        public static char[] MudarPosicaoMutacoes(char[] epiMod, char[] epiOrig, int qtdMutacoes)
        {
            for (int charPosicao = epiMod.Length - 2; charPosicao >= 0; charPosicao--)
            {
                if (epiMod[charPosicao] == '*' && epiMod[charPosicao + 1] != '*')
                {
                    epiMod[charPosicao] = epiOrig[charPosicao];
                    epiMod[charPosicao + 1] = '*';
                    break;
                }
            }

            return epiMod;
        }

        /// <summary>
        /// Apenas exibe o resultado de maneira basica e generalizada
        /// </summary>
        /// <param name="lstEpi">lista dos epitopos que contem o rank em cada epitopo</param>
        /// <param name="qtdMutacoes">quantidade de mutacoes para exibir conforme determinado</param>
        public static void ExibirResult(List<EpitopeDTO> lstEpi, int qtdMutacoes)
        {
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int contMutacao = 0; contMutacao <= qtdMutacoes; contMutacao++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                foreach (var epi in lstEpi)
                {
                    Console.WriteLine("Com {0} mutações", contMutacao);
                    Console.WriteLine("Epi: {0} -> " + "Freq: {1}", epi.LinearSequence, epi.LstProporcionalRanqueada[contMutacao].QtdCombinacoes);
                    Console.WriteLine();
                }
            }
        }
    }
}