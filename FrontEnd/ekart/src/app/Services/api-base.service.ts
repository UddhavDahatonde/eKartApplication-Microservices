import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiBaseService<T> {
  constructor(private _httpClient: HttpClient) { }

  // Method to perform a GET request
  public get(url: string): Observable<T> {
    return this._httpClient.get<T>(url);
  }
  
// Method to perform a GET request by ID
public getById<T>(url: string, id: number): Observable<T> {
  return this._httpClient.get<T>(`${url}/${id}`);
}
  // Method to perform a POST request
  public post(url: string, data: any): Observable<T> {
    return this._httpClient.post<T>(url, data);
  }

  // Method to perform a PUT request
  public put(url: string, data: any): Observable<T> {
    return this._httpClient.put<T>(url, data);
  }

  // Method to perform a DELETE request
  public delete(url: string): Observable<any> {
    return this._httpClient.delete<any>(url);
  }
}
