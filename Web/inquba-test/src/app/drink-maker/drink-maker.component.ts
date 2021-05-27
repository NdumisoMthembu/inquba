import { Component, OnInit } from '@angular/core';
import { Drink } from '../models/drink.model';
import { DrinkService } from '../services/drink.service';

@Component({
  selector: 'app-drink-maker',
  templateUrl: './drink-maker.component.html',
  styleUrls: ['./drink-maker.component.css']
})
export class DrinkMakerComponent implements OnInit {
  drink: Drink = {
    type: 'coffee',
    spoonsOfSugar: 4
  }
  drinks: Drink[];

  constructor(private drinkService: DrinkService) {


  }

  ngOnInit(): void {
  }

  makeDrink(type: string, numberOfSugars: number): void {
    this.drink = {
      type: type,
      spoonsOfSugar: numberOfSugars
    }
  }

  getDrinks() {
    this.drinks = this.drinkService.getDrinks();
  }

}
