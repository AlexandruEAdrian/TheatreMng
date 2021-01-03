import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { ActorLayoutComponent } from "./actor-layout.component";

describe("ActorLayoutComponent", () => {
  let component: ActorLayoutComponent;
  let fixture: ComponentFixture<ActorLayoutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ActorLayoutComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActorLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
