import { Component, inject } from '@angular/core';
import { ItemComponent } from '../item/item.component';
import { CommonModule } from '@angular/common';
import { Item } from '../item';
import { ItemService } from '../item.service';

@Component({
  selector: 'app-main-page',
  standalone: true,
  imports: [CommonModule, ItemComponent],
  templateUrl: `./main-page.component.html`,
  styleUrl: './main-page.component.css'
})
export class MainPageComponent {
  itemList: Item[] = [];
  itemService: ItemService = inject(ItemService);

  constructor() {
    this.itemService.getAllItems().then((itemList: Item[]) => {this.itemList = itemList}); 
  }
}
