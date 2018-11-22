using System.Collections.Generic;

namespace AMEISA.Model
{
    public class EpitopeDTO
    {
        public int IdEpitope { get; set; }
        public string LinearSequence { get; set; }

        public List<ProporcaoMutacionalDTO> LstProporcionalRanqueada { get; set; }

        public EpitopeDTO()
        {
            LstProporcionalRanqueada = new List<ProporcaoMutacionalDTO>();
        }
    }
}
