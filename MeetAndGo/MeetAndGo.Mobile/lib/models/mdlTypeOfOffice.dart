class mdlTypeOfOffice {
  final int typeOfOfficeId;
  final String name;

  mdlTypeOfOffice({
    required this.typeOfOfficeId,
    required this.name,
  });

  factory mdlTypeOfOffice.fromJson(Map<String, dynamic> json) {
    return mdlTypeOfOffice(
      typeOfOfficeId: json["typeOfOfficeId"],
      name: json["name"],
    );
  }
}
