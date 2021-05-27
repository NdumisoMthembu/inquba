import { Injectable } from '@angular/core';
import { Drink } from '../models/drink.model';

@Injectable({
  providedIn: 'root'
})
export class DrinkService {

  constructor() { }
  getDrinks(): Drink[] {
    return [
      {
        type: 'Cappuccino',
        spoonsOfSugar: 2
      },
      {
        type: 'Latte',
        spoonsOfSugar: 1
      }

    ];
  }
}
