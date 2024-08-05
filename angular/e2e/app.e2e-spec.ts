import { MyTestTemplatePage } from './app.po';

describe('MyTest App', function() {
  let page: MyTestTemplatePage;

  beforeEach(() => {
    page = new MyTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
