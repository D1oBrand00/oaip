# get what I want with the dc.SetWindowOrg calls
        pInfo.SetDraw((left, top, right, bottom))
        dc.SetWindowOrg((0, -top))

        self.OnDraw(dc)
        dc.SetTextAlign(win32con.TA_LEFT|win32con.TA_BOTTOM)

        rect = self.GetWindowRect()
        rect = self.ScreenToClient(rect)
        height = (rect[3]-rect[1])
        dc.SetWindowOrg((0, -(top+height+cyChar)))
        dc.MoveTo(left, 0)
        dc.LineTo(right, 0)

        x = 0
        y = (3*cyChar)/2

        dc.TextOut(x, y, doc.GetTitle())
        y = y + cyChar


class PrintDemoApp(app.CApp):
    def __init__(self):
        app.CApp.__init__(self)
    
    def InitInstance(self):
        template = PrintDemoTemplate(None, None,
                                     None, PrintDemoView)
        self.AddDocTemplate(template)
        self._obj_.InitMDIInstance()
        self.LoadMainFrame()
        doc = template.OpenDocumentFile(None)
        doc.SetTitle('Custom Print Document')

        
class ImagePrintDialog(dialog.PrintDi