using NuGet.Protocol.Core.Types;
using System.Net.PeerToPeer.Collaboration;

namespace BeFit.Infrastructure.SesjaTreningowaRespositories.DTO
{
    public class SesjaTreningowaDTO
    {
        public DateTime Data { get; set; }
        public int WynikId { get; set; }
        public int LiczbaSerii { get; set; } = default;
        public int LiczbaPowtorzenWSerii { get; set; } = default;
        public int IdNazwyCwiczenia { get; set; }
        public int IdSesjaTreningowa { get; set; }
    }
}
