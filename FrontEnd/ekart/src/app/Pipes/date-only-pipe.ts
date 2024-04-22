import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'dateOnly'
})
export class DateOnlyPipe implements PipeTransform {

    transform(value: any): any {
        if (value) {
          const date = new Date(value); // Convert string to Date object
          return date.toISOString().split('T')[0]; // Return only the date portion
        }
        return null;
      }
}
