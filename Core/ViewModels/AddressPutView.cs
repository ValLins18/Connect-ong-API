using System.Globalization;

namespace Connect_ong_API.Core.ViewModels {
    public record AddressPutView(string Street, string Number, string Neighborhood, string ZipCode, string State, string City);
}
