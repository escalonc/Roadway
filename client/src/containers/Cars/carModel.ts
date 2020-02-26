interface Car {
  vin: string;
  licensePlate: string;
  brand: string;
  model: string;
  version: string;
  year: number;
  color: string;
  fuel: Fuels;
  size: Sizes;
  use: Uses;
  carType: CarType;
  bank: string;
  insurance: string;
}

interface CarType {
  name: string;
}

export enum Uses {
  Personal = 1,
  Rental = 2,
  Government = 3,
  Official = 4
}

export enum Sizes {
  Small = 1,
  Medium = 2,
  Large = 3,
  ExtraLarge = 4
}

export enum Fuels {
  Gasoline = 1,
  Diesel = 2,
  Electric = 3,
  Mixed = 4
}
