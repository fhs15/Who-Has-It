import { Component, Input } from '@angular/core';
import { Item } from '../item';

@Component({
  selector: 'app-item',
  standalone: true,
  imports: [],
  templateUrl: './item.component.html',
  styleUrl: './item.component.css'
})
export class ItemComponent {
  imagePath: string = 'assets/Pictures/'
  deafultImage: string = 'Blank.png'
  @Input() item! : Item
}
