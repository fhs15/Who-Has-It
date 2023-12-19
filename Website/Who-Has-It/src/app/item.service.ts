import { Injectable } from '@angular/core';
import { Item } from './item';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  url = 'https://localhost:7049/api/Items';

  async getAllItems(): Promise<Item[]> {
    const data = await fetch(this.url)
    return await data.json() ?? []
  }

  constructor() { }
}
