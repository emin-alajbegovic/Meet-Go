import 'dart:convert';

class mdlRentedOffice {
  final int rentedOfficeId;
  final int officeId;
  final int userId;
  final String beginRentalDate;
  final String endRentalDate;
  final bool rented;
  final String office;
  final String firstName;
  final String lastName;
  final int days;
  final int officePrice;
  final double price;
  final String address;
  final List<int> picture;

  mdlRentedOffice({
    required this.rentedOfficeId,
    required this.officeId,
    required this.userId,
    required this.beginRentalDate,
    required this.endRentalDate,
    required this.rented,
    required this.office,
    required this.firstName,
    required this.lastName,
    required this.days,
    required this.officePrice,
    required this.price,
    required this.address,
    required this.picture,
  });

  factory mdlRentedOffice.fromJson(Map<String, dynamic> json) {
    String stringByte = json["picture"] as String;
    List<int> bytes = base64.decode(stringByte);
    return mdlRentedOffice(
      rentedOfficeId: int.parse(json["rentedOfficeId"].toString()),
      officeId: int.parse(json["officeId"].toString()),
      userId: int.parse(json["userId"].toString()),
      beginRentalDate: DateTime.parse(json["beginRentalDate"]).toString(),
      endRentalDate: DateTime.parse(json["endRentalDate"]).toString(),
      rented: json["rented"],
      office: json["office"],
      firstName: json["firstname"],
      lastName: json["lastName"],
      days: json["days"],
      officePrice: json["officePrice"],
      price: json["price"],
      address: json["adress"],
      picture: bytes,
    );
  }
}
