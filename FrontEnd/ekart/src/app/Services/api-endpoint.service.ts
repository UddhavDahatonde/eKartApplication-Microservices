import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiEndpointService {

  constructor() { }
  readonly productUrl = 'https://localhost:7000';
}
