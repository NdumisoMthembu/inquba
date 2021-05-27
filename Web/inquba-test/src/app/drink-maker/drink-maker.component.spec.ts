import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DrinkMakerComponent } from './drink-maker.component';

describe('DrinkMakerComponent', () => {
  let component: DrinkMakerComponent;
  let fixture: ComponentFixture<DrinkMakerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DrinkMakerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DrinkMakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should make a drink', () => {
    fixture = TestBed.createComponent(DrinkMakerComponent);
    component = fixture.componentInstance;
    component.makeDrink('latte', 3);
    expect(component.drink.type).toBe("latte");
  });
  it('should return 2 drinks', () => {
    fixture = TestBed.createComponent(DrinkMakerComponent);
    component = fixture.componentInstance;
    component.getDrinks();
    expect(component.drinks && component.drinks.length).toBe(2);
  });
});
