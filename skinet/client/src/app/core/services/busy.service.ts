import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequetCount = 0;
  constructor(private spinnerService: NgxSpinnerService) {
  }
  busy() {
    this.busyRequetCount++;
    this.spinnerService.show(undefined, {
      type: 'timer', bdColor: 'rgba(255,255,255,0.7)',
      color: '#333333'
    });
  }

  idle() {
    this.busyRequetCount--;
    if (this.busyRequetCount <= 0) {
      this.busyRequetCount = 0;
      this.spinnerService.hide();
    }
  }
}
