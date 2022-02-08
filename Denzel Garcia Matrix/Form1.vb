Public Class Form1
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tt1.Visible = False
        tt2.Visible = False
        tt3.Visible = False
        tt4.Visible = False

        tt11.Visible = False
        tt12.Visible = False
        tt13.Visible = False
        tt14.Visible = False

        tt21.Visible = False
        tt22.Visible = False
        tt23.Visible = False
        tt24.Visible = False

        tt31.Visible = False
        tt32.Visible = False
        tt33.Visible = False
        tt34.Visible = False

        t1.Visible = False
        t2.Visible = False
        t3.Visible = False
        t4.Visible = False

        t11.Visible = False
        t12.Visible = False
        t13.Visible = False
        t14.Visible = False

        t21.Visible = False
        t22.Visible = False
        t23.Visible = False
        t24.Visible = False

        t31.Visible = False
        t32.Visible = False
        t33.Visible = False
        t34.Visible = False

        s1.Visible = False
        s2.Visible = False
        s3.Visible = False
        s4.Visible = False

        s11.Visible = False
        s12.Visible = False
        s13.Visible = False
        s14.Visible = False

        s21.Visible = False
        s22.Visible = False
        s23.Visible = False
        s24.Visible = False

        s31.Visible = False
        s32.Visible = False
        s33.Visible = False
        s34.Visible = False

        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        a4.Visible = False

        a11.Visible = False
        a12.Visible = False
        a13.Visible = False
        a14.Visible = False

        a21.Visible = False
        a22.Visible = False
        a23.Visible = False
        a24.Visible = False

        a31.Visible = False
        a32.Visible = False
        a33.Visible = False
        a34.Visible = False

        adj.Visible = False

    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        'Addtion

        If (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x2") Then


            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Then
                MessageBox.Show("Fill Up Matrix", "Error")




            Else

                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)


                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "2x3" And cb2.SelectedItem = "2x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Then

                ' 2x3 + 2x3 down left
                MessageBox.Show("Fill Up Matrix", "Error")



            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim f = Val(t3.Text) + Val(tt3.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim g = Val(t13.Text) + Val(tt13.Text)

                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()


                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + f.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + g.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "2x4" And cb2.SelectedItem = "2x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Then

                ' 2x4 + 2x4 down left
                MessageBox.Show("Fill Up Matrix", "Error")





            Else
                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim f = Val(t3.Text) + Val(tt3.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim g = Val(t13.Text) + Val(tt13.Text)
                Dim h = Val(t4.Text) + Val(tt4.Text)
                Dim i = Val(t14.Text) + Val(tt14.Text)
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a4.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()
                a14.Text = i.ToString()



                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + f.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + h.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + g.ToString()
                s14.Text = t4.Text + "+" + tt14.Text + "=" + i.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False


            End If
        ElseIf (cb1.SelectedItem = "3x2" And cb2.SelectedItem = "3x2") Then

            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Then

                '3x2 + 3x2 

                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Then

                '3x3 + 3x3 

                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)
                Dim h = Val(t3.Text) + Val(tt3.Text)
                Dim i = Val(t13.Text) + Val(tt13.Text)
                Dim j = Val(t23.Text) + Val(tt23.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + h.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + i.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + j.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a3.Text = h.ToString()
                a13.Text = i.ToString()
                a23.Text = j.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x4" And cb2.SelectedItem = "3x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Then

                '3x4 + 3x4 

                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)
                Dim h = Val(t3.Text) + Val(tt3.Text)
                Dim i = Val(t13.Text) + Val(tt13.Text)
                Dim j = Val(t23.Text) + Val(tt23.Text)
                Dim k = Val(t4.Text) + Val(tt4.Text)
                Dim l = Val(t14.Text) + Val(tt14.Text)
                Dim m = Val(t24.Text) + Val(tt24.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + h.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + i.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + j.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + k.ToString()
                s14.Text = t14.Text + "+" + tt14.Text + "=" + l.ToString()
                s24.Text = t24.Text + "+" + tt24.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a3.Text = h.ToString()
                a13.Text = i.ToString()
                a23.Text = j.ToString()
                a4.Text = k.ToString()
                a14.Text = l.ToString()
                a24.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "4x2") Then

            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "" Then

                '4x2 + 4x2 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)
                Dim h = Val(t31.Text) + Val(tt31.Text)
                Dim i = Val(t32.Text) + Val(tt32.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "4x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Then

                '4x3 + 4x3 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)
                Dim h = Val(t31.Text) + Val(tt31.Text)
                Dim i = Val(t32.Text) + Val(tt32.Text)
                Dim j = Val(t3.Text) + Val(tt3.Text)
                Dim k = Val(t13.Text) + Val(tt13.Text)
                Dim l = Val(t23.Text) + Val(tt23.Text)
                Dim m = Val(t33.Text) + Val(tt33.Text)
                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + j.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + k.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + l.ToString()
                s33.Text = t33.Text + "+" + tt33.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a3.Text = j.ToString()
                a13.Text = k.ToString()
                a23.Text = l.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "" Then

                '4x4 + 4x4 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) + Val(tt1.Text)
                Dim b = Val(t2.Text) + Val(tt2.Text)
                Dim c = Val(t11.Text) + Val(tt11.Text)
                Dim d = Val(t12.Text) + Val(tt12.Text)
                Dim f = Val(t21.Text) + Val(tt21.Text)
                Dim g = Val(t22.Text) + Val(tt22.Text)
                Dim h = Val(t31.Text) + Val(tt31.Text)
                Dim i = Val(t32.Text) + Val(tt32.Text)
                Dim j = Val(t3.Text) + Val(tt3.Text)
                Dim k = Val(t13.Text) + Val(tt13.Text)
                Dim l = Val(t23.Text) + Val(tt23.Text)
                Dim m = Val(t33.Text) + Val(tt33.Text)
                Dim n = Val(t4.Text) + Val(tt4.Text)
                Dim o = Val(t14.Text) + Val(tt14.Text)
                Dim p = Val(t24.Text) + Val(tt24.Text)
                Dim q = Val(t34.Text) + Val(tt34.Text)
                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + j.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + k.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + l.ToString()
                s33.Text = t33.Text + "+" + tt33.Text + "=" + m.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + n.ToString()
                s14.Text = t14.Text + "+" + tt14.Text + "=" + o.ToString()
                s24.Text = t24.Text + "+" + tt24.Text + "=" + p.ToString()
                s34.Text = t34.Text + "+" + tt34.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a3.Text = j.ToString()
                a13.Text = k.ToString()
                a23.Text = l.ToString()
                a33.Text = m.ToString()
                a4.Text = n.ToString()
                a14.Text = o.ToString()
                a24.Text = p.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If
        ElseIf cb1.SelectedItem = Nothing Or cb2.SelectedItem = Nothing Then

            MessageBox.Show("Please select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Matrix should be same Dimension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'End Of Addtion

    End Sub 'Addition

    Private Sub subt_Click(sender As Object, e As EventArgs) Handles subt.Click
        If (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x2") Then


            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Then
                MessageBox.Show("Fill Up Matrix", "Error")




            Else

                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)


                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "2x3" And cb2.SelectedItem = "2x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Then

                ' 2x3 + 2x3 down left
                MessageBox.Show("Fill Up Matrix", "Error")



            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim f = Val(t3.Text) - Val(tt3.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim g = Val(t13.Text) - Val(tt13.Text)

                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()


                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + f.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + g.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "2x4" And cb2.SelectedItem = "2x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Then

                ' 2x4 + 2x4 down left

                MessageBox.Show("Fill Up Matrix", "Error")



            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim f = Val(t3.Text) - Val(tt3.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim g = Val(t13.Text) - Val(tt13.Text)
                Dim h = Val(t4.Text) - Val(tt4.Text)
                Dim i = Val(t14.Text) - Val(tt14.Text)
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a4.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()
                a14.Text = i.ToString()



                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + f.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + h.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + g.ToString()
                s14.Text = t4.Text + "+" + tt14.Text + "=" + i.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "3x2" And cb2.SelectedItem = "3x2") Then

            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Then

                '3x2 + 3x2 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False


            End If
        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Then

                '3x3 + 3x3 

                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)
                Dim h = Val(t3.Text) - Val(tt3.Text)
                Dim i = Val(t13.Text) - Val(tt13.Text)
                Dim j = Val(t23.Text) - Val(tt23.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + h.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + i.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + j.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a3.Text = h.ToString()
                a13.Text = i.ToString()
                a23.Text = j.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x4" And cb2.SelectedItem = "3x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Then

                '3x4 + 3x4 

                MessageBox.Show("Fill Up Matrix", "Error")

            Else
                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)
                Dim h = Val(t3.Text) - Val(tt3.Text)
                Dim i = Val(t13.Text) - Val(tt13.Text)
                Dim j = Val(t23.Text) - Val(tt23.Text)
                Dim k = Val(t4.Text) - Val(tt4.Text)
                Dim l = Val(t14.Text) - Val(tt14.Text)
                Dim m = Val(t24.Text) - Val(tt24.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + h.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + i.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + j.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + k.ToString()
                s14.Text = t14.Text + "+" + tt14.Text + "=" + l.ToString()
                s24.Text = t24.Text + "+" + tt24.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a3.Text = h.ToString()
                a13.Text = i.ToString()
                a23.Text = j.ToString()
                a4.Text = k.ToString()
                a14.Text = l.ToString()
                a24.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False


            End If
        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "4x2") Then

            If t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "" Then

                '4x2 + 4x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)
                Dim h = Val(t31.Text) - Val(tt31.Text)
                Dim i = Val(t32.Text) - Val(tt32.Text)

                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False


            End If
        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "4x3") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Then

                '4x3 + 4x3 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)
                Dim h = Val(t31.Text) - Val(tt31.Text)
                Dim i = Val(t32.Text) - Val(tt32.Text)
                Dim j = Val(t3.Text) - Val(tt3.Text)
                Dim k = Val(t13.Text) - Val(tt13.Text)
                Dim l = Val(t23.Text) - Val(tt23.Text)
                Dim m = Val(t33.Text) - Val(tt33.Text)
                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + j.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + k.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + l.ToString()
                s33.Text = t33.Text + "+" + tt33.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a3.Text = j.ToString()
                a13.Text = k.ToString()
                a23.Text = l.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False

            End If
        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x4") Then

            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "" Then

                '4x4 + 4x4 
                MessageBox.Show("Fill Up Matrix", "Error")


            Else


                Dim a = Val(t1.Text) - Val(tt1.Text)
                Dim b = Val(t2.Text) - Val(tt2.Text)
                Dim c = Val(t11.Text) - Val(tt11.Text)
                Dim d = Val(t12.Text) - Val(tt12.Text)
                Dim f = Val(t21.Text) - Val(tt21.Text)
                Dim g = Val(t22.Text) - Val(tt22.Text)
                Dim h = Val(t31.Text) - Val(tt31.Text)
                Dim i = Val(t32.Text) - Val(tt32.Text)
                Dim j = Val(t3.Text) - Val(tt3.Text)
                Dim k = Val(t13.Text) - Val(tt13.Text)
                Dim l = Val(t23.Text) - Val(tt23.Text)
                Dim m = Val(t33.Text) - Val(tt33.Text)
                Dim n = Val(t4.Text) - Val(tt4.Text)
                Dim o = Val(t14.Text) - Val(tt14.Text)
                Dim p = Val(t24.Text) - Val(tt24.Text)
                Dim q = Val(t34.Text) - Val(tt34.Text)
                s1.Text = t1.Text + "+" + tt1.Text + "=" + a.ToString()
                s2.Text = t2.Text + "+" + tt2.Text + "=" + b.ToString()
                s11.Text = t11.Text + "+" + tt11.Text + "=" + c.ToString()
                s12.Text = t12.Text + "+" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "+" + tt21.Text + "=" + f.ToString()
                s22.Text = t22.Text + "+" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "+" + tt31.Text + "=" + h.ToString()
                s32.Text = t32.Text + "+" + tt32.Text + "=" + i.ToString()
                s3.Text = t3.Text + "+" + tt3.Text + "=" + j.ToString()
                s13.Text = t13.Text + "+" + tt13.Text + "=" + k.ToString()
                s23.Text = t23.Text + "+" + tt23.Text + "=" + l.ToString()
                s33.Text = t33.Text + "+" + tt33.Text + "=" + m.ToString()
                s4.Text = t4.Text + "+" + tt4.Text + "=" + n.ToString()
                s14.Text = t14.Text + "+" + tt14.Text + "=" + o.ToString()
                s24.Text = t24.Text + "+" + tt24.Text + "=" + p.ToString()
                s34.Text = t34.Text + "+" + tt34.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a3.Text = j.ToString()
                a13.Text = k.ToString()
                a23.Text = l.ToString()
                a33.Text = m.ToString()
                a4.Text = n.ToString()
                a14.Text = o.ToString()
                a24.Text = p.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If
        ElseIf cb1.SelectedItem = Nothing And cb2.SelectedItem = Nothing Then

            MessageBox.Show("Please select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Matrix should be same Dimension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'End Of Addtion
    End Sub 'Subtraction
    Public Sub cleartextbox(ByVal root As Control)
        For Each crtl As Control In root.Controls
            cleartextbox(crtl)
            If TypeOf crtl Is TextBox Then
                CType(crtl, TextBox).Text = String.Empty
            End If
        Next
    End Sub
    Private Sub cl_Click(sender As Object, e As EventArgs) Handles cl.Click
        'Clear
        cleartextbox(Me)

        s1.Visible = False
        s2.Visible = False
        s3.Visible = False
        s4.Visible = False

        s11.Visible = False
        s12.Visible = False
        s13.Visible = False
        s14.Visible = False

        s21.Visible = False
        s22.Visible = False
        s23.Visible = False
        s24.Visible = False

        s31.Visible = False
        s32.Visible = False
        s33.Visible = False
        s34.Visible = False

        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        a4.Visible = False

        a11.Visible = False
        a12.Visible = False
        a13.Visible = False
        a14.Visible = False

        a21.Visible = False
        a22.Visible = False
        a23.Visible = False
        a24.Visible = False

        a31.Visible = False
        a32.Visible = False
        a33.Visible = False
        a34.Visible = False

    End Sub 'Clear

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        'cb1
        If (cb1.SelectedItem = Nothing) Then


            t1.Visible = False
            t2.Visible = False
            t3.Visible = False
            t4.Visible = False

            t11.Visible = False
            t12.Visible = False
            t13.Visible = False
            t14.Visible = False

            t21.Visible = False
            t22.Visible = False
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "2x2") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = False
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = False
            t14.Visible = False

            t21.Visible = False
            t22.Visible = False
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "2x3") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = False

            t21.Visible = False
            t22.Visible = False
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "2x4") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = True

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = True

            t21.Visible = False
            t22.Visible = False
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "3x2") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = False
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = False
            t14.Visible = False

            t21.Visible = True
            t22.Visible = True
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "3x3") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = False

            t21.Visible = True
            t22.Visible = True
            t23.Visible = True
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "3x4") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = True

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = True

            t21.Visible = True
            t22.Visible = True
            t23.Visible = True
            t24.Visible = True

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "4x2") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = False
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = False
            t14.Visible = False

            t21.Visible = True
            t22.Visible = True
            t23.Visible = False
            t24.Visible = False

            t31.Visible = True
            t32.Visible = True
            t33.Visible = False
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "4x3") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = False

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = False

            t21.Visible = True
            t22.Visible = True
            t23.Visible = True
            t24.Visible = False

            t31.Visible = True
            t32.Visible = True
            t33.Visible = True
            t34.Visible = False

        ElseIf (cb1.SelectedItem = "4x4") Then

            t1.Visible = True
            t2.Visible = True
            t3.Visible = True
            t4.Visible = True

            t11.Visible = True
            t12.Visible = True
            t13.Visible = True
            t14.Visible = True

            t21.Visible = True
            t22.Visible = True
            t23.Visible = True
            t24.Visible = True

            t31.Visible = True
            t32.Visible = True
            t33.Visible = True
            t34.Visible = True

        Else

            t1.Visible = False
            t2.Visible = False
            t3.Visible = False
            t4.Visible = False

            t11.Visible = False
            t12.Visible = False
            t13.Visible = False
            t14.Visible = False

            t21.Visible = False
            t22.Visible = False
            t23.Visible = False
            t24.Visible = False

            t31.Visible = False
            t32.Visible = False
            t33.Visible = False
            t34.Visible = False
        End If
        'end cb1
    End Sub 'cb1

    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb2.SelectedIndexChanged

        'cb2
        If (cb2.SelectedItem = Nothing) Then

            tt1.Visible = False
            tt2.Visible = False
            tt3.Visible = False
            tt4.Visible = False

            tt11.Visible = False
            tt12.Visible = False
            tt13.Visible = False
            tt14.Visible = False

            tt21.Visible = False
            tt22.Visible = False
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "2x2") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = False
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = False
            tt14.Visible = False

            tt21.Visible = False
            tt22.Visible = False
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "2x3") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = False

            tt21.Visible = False
            tt22.Visible = False
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "2x4") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = True

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = True

            tt21.Visible = False
            tt22.Visible = False
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "3x2") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = False
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = False
            tt14.Visible = False

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "3x3") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = False

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = True
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "3x4") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = True

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = True

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = True
            tt24.Visible = True

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "4x2") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = False
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = False
            tt14.Visible = False

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = True
            tt32.Visible = True
            tt33.Visible = False
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "4x3") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = False

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = False

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = True
            tt24.Visible = False

            tt31.Visible = True
            tt32.Visible = True
            tt33.Visible = True
            tt34.Visible = False

        ElseIf (cb2.SelectedItem = "4x4") Then

            tt1.Visible = True
            tt2.Visible = True
            tt3.Visible = True
            tt4.Visible = True

            tt11.Visible = True
            tt12.Visible = True
            tt13.Visible = True
            tt14.Visible = True

            tt21.Visible = True
            tt22.Visible = True
            tt23.Visible = True
            tt24.Visible = True

            tt31.Visible = True
            tt32.Visible = True
            tt33.Visible = True
            tt34.Visible = True

        Else

            tt1.Visible = False
            tt2.Visible = False
            tt3.Visible = False
            tt4.Visible = False

            tt11.Visible = False
            tt12.Visible = False
            tt13.Visible = False
            tt14.Visible = False

            tt21.Visible = False
            tt22.Visible = False
            tt23.Visible = False
            tt24.Visible = False

            tt31.Visible = False
            tt32.Visible = False
            tt33.Visible = False
            tt34.Visible = False
            'end cb2
        End If
    End Sub 'Cb2

    Private Sub mul_Click(sender As Object, e As EventArgs) Handles mul.Click
        If (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x2") Then
            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                '2x2 x 2x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "") Then

                '2x2 x 2x3 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + f.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a3.Text = f.ToString()
                a13.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "") Then

                '2x2 x 2x4 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim h = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text)
                Dim i = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + f.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + g.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "= " + h.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a3.Text = f.ToString()
                a13.Text = g.ToString()
                a4.Text = h.ToString()
                a14.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If
        ElseIf (cb1.SelectedItem = "2x3" And cb2.SelectedItem = "3x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "") Then

                '2x3 x 3x2 
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "2x3" And cb2.SelectedItem = "3x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "") Then

                '2x3 x 3x3 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a3.Text = f.ToString()
                a13.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "2x3" And cb2.SelectedItem = "3x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "") Then

                '2x3 x 3x4 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim h = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim i = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + f.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "= " + h.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + g.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a3.Text = f.ToString()
                a13.Text = g.ToString()
                a4.Text = h.ToString()
                a14.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "2x4" And cb2.SelectedItem = "4x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "") Then

                '2x4 x 4x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "2x4" And cb2.SelectedItem = "4x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "") Then

                '2x4 x 4x3 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + t4.Text + "x" + tt33.Text + "= " + f.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + t14.Text + "x" + tt33.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "2x4" And cb2.SelectedItem = "4x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                '2x4 x 4x4 
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim f = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim h = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text) + Val(t4.Text) * Val(tt34.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim g = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim i = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text) + Val(t14.Text) * Val(tt34.Text)
                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + t4.Text + "x" + tt33.Text + "= " + f.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + t4.Text + "x" + tt34.Text + "= " + h.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + t14.Text + "x" + tt33.Text + "=" + g.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + t14.Text + "x" + tt34.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = f.ToString()
                a4.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = g.ToString()
                a14.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "3x2" And cb2.SelectedItem = "2x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                '3x2 x 2x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt22.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x2" And cb2.SelectedItem = "2x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "") Then

                '3x2 x 2x3 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + h.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + i.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt23.Text + "=" + j.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "3x2" And cb2.SelectedItem = "2x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "") Then

                '3x2 x 2x4 
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim k = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim l = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim m = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + h.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "= " + k.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + i.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "=" + l.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt23.Text + "=" + j.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt24.Text + "=" + m.ToString().ToString
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a4.Text = k.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a14.Text = l.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                a24.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "") Then

                '3x3 x 3x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "= " + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "") Then

                '3x3 x 3x3 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + +Val(t23.Text) * Val(tt23.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + h.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "= " + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "= " + i.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + j.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "") Then

                '3x3 x 3x4 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim k = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim l = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + +Val(t23.Text) * Val(tt23.Text)
                Dim m = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + +Val(t23.Text) * Val(tt24.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + h.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "= " + k.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "= " + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "= " + i.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "= " + l.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + j.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a4.Text = k.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a14.Text = l.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                a24.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = "3x4" And cb2.SelectedItem = "4x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "") Then

                '3x4 x 4x2 
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "= " + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()

                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If
        ElseIf (cb1.SelectedItem = "3x4" And cb2.SelectedItem = "4x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "") Then

                '3x4 x 4x3 
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + +Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + h.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "= " + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "= " + i.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + j.ToString()

                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                '4x2 x 2x2
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "") Then

                '4x2 x 2x3
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False

            End If
        ElseIf (cb1.SelectedItem = "3x4" And cb2.SelectedItem = "4x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                '3x4 x 4x4 
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim h = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim k = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text) + Val(t4.Text) * Val(tt34.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim i = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim l = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text) + Val(t14.Text) * Val(tt34.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + +Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim j = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + +Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)
                Dim m = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + +Val(t23.Text) * Val(tt24.Text) + Val(t24.Text) * Val(tt34.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + h.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "+" + t4.Text + "x" + tt34.Text + "= " + k.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "= " + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "= " + i.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "+" + t14.Text + "x" + tt34.Text + "= " + l.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt21.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + j.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "+" + t24.Text + "x" + tt34.Text + "=" + m.ToString()

                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = h.ToString()
                a4.Text = k.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = i.ToString()
                a14.Text = l.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = j.ToString()
                a24.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                '4x2 x 2x2
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "") Then

                '4x2 x 2x3
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "") Then

                '4x2 x 2x4
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If

        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "") Then

                '4x2 x 3x2
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "") Then

                '4x3 x 3x3
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "") Then

                '4x3 x 3x4
                MessageBox.Show("Fill Up Matrix", "Error")
            Else
                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + Val(t23.Text) * Val(tt24.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text) + Val(t33.Text) * Val(tt24.Text)
                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "+" + t33.Text + "x" + tt24.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If
        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                '4x2 x 2x2
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "") Then

                '4x2 x 2x3
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "4x2" And cb2.SelectedItem = "2x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t21.Text = "" Or t22.Text = "" Or t31.Text = "" Or t32.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "") Then

                '4x2 x 2x4
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If

        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "") Then

                '4x2 x 3x2
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "") Then

                '4x3 x 3x3
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "4x3" And cb2.SelectedItem = "3x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "") Then

                '4x3 x 3x4
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + Val(t23.Text) * Val(tt24.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text) + Val(t33.Text) * Val(tt24.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "+" + t33.Text + "x" + tt24.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If

        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "") Then

                '4x4 x 4x2
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False

            End If


        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "") Then

                '4x4 x 4x3
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text) + Val(t34.Text) * Val(tt33.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "+" + t34.Text + "x" + tt33.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False


            End If

        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                '4x4 x 4x4
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text) + Val(t4.Text) * Val(tt34.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text) + Val(t14.Text) * Val(tt34.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + Val(t23.Text) * Val(tt24.Text) + Val(t24.Text) * Val(tt34.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text) + Val(t34.Text) * Val(tt33.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text) + Val(t33.Text) * Val(tt24.Text) + Val(t34.Text) * Val(tt34.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "+" + t4.Text + "x" + tt34.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "+" + t14.Text + "x" + tt34.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "+" + t24.Text + "x" + tt34.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "+" + t34.Text + "x" + tt33.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "+" + t33.Text + "x" + tt24.Text + "+" + t34.Text + "x" + tt34.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True

            End If
        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x2") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt31.Text = "" Or tt32.Text = "") Then

                '4x4 x 4x2
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)

                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = False
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = False
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = False
                a34.Visible = False
            End If


        ElseIf (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x3") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "") Then

                '4x4 x 4x3
                MessageBox.Show("Fill Up Matrix", "Error")
            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text) + Val(t34.Text) * Val(tt33.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + j.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "=" + k.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + l.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "+" + t34.Text + "x" + tt33.Text + "=" + m.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = False


            End If

        ElseIf (cb1.SelectedItem = "4x4" Or cb2.SelectedItem = "4x4") Then

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                '4x4 x 4x4
                MessageBox.Show("Fill Up Matrix", "Error")

            Else


                Dim a = Val(t1.Text) * Val(tt1.Text) + Val(t2.Text) * Val(tt11.Text) + Val(t3.Text) * Val(tt21.Text) + Val(t4.Text) * Val(tt31.Text)
                Dim b = Val(t1.Text) * Val(tt2.Text) + Val(t2.Text) * Val(tt12.Text) + Val(t3.Text) * Val(tt22.Text) + Val(t4.Text) * Val(tt32.Text)
                Dim j = Val(t1.Text) * Val(tt3.Text) + Val(t2.Text) * Val(tt13.Text) + Val(t3.Text) * Val(tt23.Text) + Val(t4.Text) * Val(tt33.Text)
                Dim n = Val(t1.Text) * Val(tt4.Text) + Val(t2.Text) * Val(tt14.Text) + Val(t3.Text) * Val(tt24.Text) + Val(t4.Text) * Val(tt34.Text)
                Dim c = Val(t11.Text) * Val(tt1.Text) + Val(t12.Text) * Val(tt11.Text) + Val(t13.Text) * Val(tt21.Text) + Val(t14.Text) * Val(tt31.Text)
                Dim d = Val(t11.Text) * Val(tt2.Text) + Val(t12.Text) * Val(tt12.Text) + Val(t13.Text) * Val(tt22.Text) + Val(t14.Text) * Val(tt32.Text)
                Dim k = Val(t11.Text) * Val(tt3.Text) + Val(t12.Text) * Val(tt13.Text) + Val(t13.Text) * Val(tt23.Text) + Val(t14.Text) * Val(tt33.Text)
                Dim o = Val(t11.Text) * Val(tt4.Text) + Val(t12.Text) * Val(tt14.Text) + Val(t13.Text) * Val(tt24.Text) + Val(t14.Text) * Val(tt34.Text)
                Dim f = Val(t21.Text) * Val(tt1.Text) + Val(t22.Text) * Val(tt11.Text) + Val(t23.Text) * Val(tt21.Text) + Val(t24.Text) * Val(tt31.Text)
                Dim g = Val(t21.Text) * Val(tt2.Text) + Val(t22.Text) * Val(tt12.Text) + Val(t23.Text) * Val(tt22.Text) + Val(t24.Text) * Val(tt32.Text)
                Dim l = Val(t21.Text) * Val(tt3.Text) + Val(t22.Text) * Val(tt13.Text) + Val(t23.Text) * Val(tt23.Text) + Val(t24.Text) * Val(tt33.Text)
                Dim p = Val(t21.Text) * Val(tt4.Text) + Val(t22.Text) * Val(tt14.Text) + Val(t23.Text) * Val(tt24.Text) + Val(t24.Text) * Val(tt34.Text)
                Dim h = Val(t31.Text) * Val(tt1.Text) + Val(t32.Text) * Val(tt11.Text) + Val(t33.Text) * Val(tt21.Text) + Val(t34.Text) * Val(tt31.Text)
                Dim i = Val(t31.Text) * Val(tt2.Text) + Val(t32.Text) * Val(tt12.Text) + Val(t33.Text) * Val(tt22.Text) + Val(t34.Text) * Val(tt32.Text)
                Dim m = Val(t31.Text) * Val(tt3.Text) + Val(t32.Text) * Val(tt13.Text) + Val(t33.Text) * Val(tt23.Text) + Val(t34.Text) * Val(tt33.Text)
                Dim q = Val(t31.Text) * Val(tt4.Text) + Val(t32.Text) * Val(tt14.Text) + Val(t33.Text) * Val(tt24.Text) + Val(t34.Text) * Val(tt34.Text)


                s1.Text = t1.Text + "x" + tt1.Text + "+" + t2.Text + "x" + tt11.Text + "+" + t3.Text + "x" + tt21.Text + "+" + t4.Text + "x" + tt31.Text + "= " + a.ToString()
                s2.Text = t1.Text + "x" + tt2.Text + "+" + t2.Text + "x" + tt12.Text + "+" + t3.Text + "x" + tt22.Text + "+" + t4.Text + "x" + tt32.Text + "= " + b.ToString()
                s3.Text = t1.Text + "x" + tt3.Text + "+" + t2.Text + "x" + tt13.Text + "+" + t3.Text + "x" + tt23.Text + "+" + t4.Text + "x" + tt33.Text + "= " + j.ToString()
                s4.Text = t1.Text + "x" + tt4.Text + "+" + t2.Text + "x" + tt14.Text + "+" + t3.Text + "x" + tt24.Text + "+" + t4.Text + "x" + tt34.Text + "= " + n.ToString()
                s11.Text = t11.Text + "x" + tt1.Text + "+" + t12.Text + "x" + tt11.Text + "+" + t13.Text + "x" + tt21.Text + "+" + t14.Text + "x" + tt31.Text + "= " + c.ToString()
                s12.Text = t11.Text + "x" + tt2.Text + "+" + t12.Text + "x" + tt12.Text + "+" + t13.Text + "x" + tt22.Text + "+" + t14.Text + "x" + tt32.Text + "=" + d.ToString()
                s13.Text = t11.Text + "x" + tt3.Text + "+" + t12.Text + "x" + tt13.Text + "+" + t13.Text + "x" + tt23.Text + "+" + t14.Text + "x" + tt33.Text + "=" + k.ToString()
                s14.Text = t11.Text + "x" + tt4.Text + "+" + t12.Text + "x" + tt14.Text + "+" + t13.Text + "x" + tt24.Text + "+" + t14.Text + "x" + tt34.Text + "=" + o.ToString()
                s21.Text = t21.Text + "x" + tt1.Text + "+" + t22.Text + "x" + tt11.Text + "+" + t23.Text + "x" + tt21.Text + "+" + t24.Text + "x" + tt31.Text + "= " + f.ToString()
                s22.Text = t21.Text + "x" + tt2.Text + "+" + t22.Text + "x" + tt12.Text + "+" + t23.Text + "x" + tt22.Text + "+" + t24.Text + "x" + tt32.Text + "=" + g.ToString()
                s23.Text = t21.Text + "x" + tt3.Text + "+" + t22.Text + "x" + tt13.Text + "+" + t23.Text + "x" + tt23.Text + "+" + t24.Text + "x" + tt33.Text + "=" + l.ToString()
                s24.Text = t21.Text + "x" + tt4.Text + "+" + t22.Text + "x" + tt14.Text + "+" + t23.Text + "x" + tt24.Text + "+" + t24.Text + "x" + tt34.Text + "=" + p.ToString()
                s31.Text = t31.Text + "x" + tt1.Text + "+" + t32.Text + "x" + tt11.Text + "+" + t33.Text + "x" + tt21.Text + "+" + t34.Text + "x" + tt31.Text + "= " + h.ToString()
                s32.Text = t31.Text + "x" + tt2.Text + "+" + t32.Text + "x" + tt12.Text + "+" + t33.Text + "x" + tt22.Text + "+" + t34.Text + "x" + tt32.Text + "=" + i.ToString()
                s33.Text = t31.Text + "x" + tt3.Text + "+" + t32.Text + "x" + tt13.Text + "+" + t33.Text + "x" + tt23.Text + "+" + t34.Text + "x" + tt33.Text + "=" + m.ToString()
                s34.Text = t31.Text + "x" + tt4.Text + "+" + t32.Text + "x" + tt14.Text + "+" + t33.Text + "x" + tt24.Text + "+" + t34.Text + "x" + tt34.Text + "=" + q.ToString()
                a1.Text = a.ToString()
                a2.Text = b.ToString()
                a3.Text = j.ToString()
                a4.Text = n.ToString()
                a11.Text = c.ToString()
                a12.Text = d.ToString()
                a13.Text = k.ToString()
                a14.Text = o.ToString()
                a21.Text = f.ToString()
                a22.Text = g.ToString()
                a23.Text = l.ToString()
                a24.Text = p.ToString()
                a31.Text = h.ToString()
                a32.Text = i.ToString()
                a33.Text = m.ToString()
                a34.Text = q.ToString()
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True


            End If

        ElseIf (cb1.SelectedItem = Nothing Or cb2.SelectedItem = Nothing) Then

            MessageBox.Show("Please select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Invalid! columns and rows are EQUAL!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If






    End Sub 'Multiplication

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        'division
        Dim a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q As Decimal
        Dim ss0, ss1, ss2, ss3, ss4, ss5, c0, c1, c2, c3, c4, c5 As Decimal
        Dim invdet, invdet1, ad, add, i1, i2, i3, i4, i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34 As Decimal
        Dim in1, in2, in3, in4, in11, in12, in13, in14, in21, in22, in23, in24, in31, in32, in33, in34 As Decimal
        Dim adj1, adj2, adj3, adj11, adj12, adj13, adj21, adj22, adj23 As Decimal
        invdet.ToString()

        If (cb1.SelectedItem = "4x4" And cb2.SelectedItem = "4x4") Then
            '4x4 / 4x4

            ss0 = Val(tt1.Text) * Val(tt12.Text) - Val(tt11.Text) * Val(tt2.Text)
            ss1 = Val(tt1.Text) * Val(tt13.Text) - Val(tt11.Text) * Val(tt3.Text)
            ss2 = Val(tt1.Text) * Val(tt14.Text) - Val(tt11.Text) * Val(tt4.Text)
            ss3 = Val(tt2.Text) * Val(tt13.Text) - Val(tt12.Text) * Val(tt3.Text)
            ss4 = Val(tt2.Text) * Val(tt14.Text) - Val(tt12.Text) * Val(tt4.Text)
            ss5 = Val(tt3.Text) * Val(tt14.Text) - Val(tt13.Text) * Val(tt4.Text)

            c5 = Val(tt23.Text) * Val(tt34.Text) - Val(tt33.Text) * Val(tt24.Text)
            c4 = Val(tt22.Text) * Val(tt34.Text) - Val(tt32.Text) * Val(tt24.Text)
            c3 = Val(tt22.Text) * Val(tt33.Text) - Val(tt32.Text) * Val(tt23.Text)
            c2 = Val(tt21.Text) * Val(tt34.Text) - Val(tt31.Text) * Val(tt24.Text)
            c1 = Val(tt21.Text) * Val(tt33.Text) - Val(tt31.Text) * Val(tt23.Text)
            c0 = Val(tt21.Text) * Val(tt32.Text) - Val(tt31.Text) * Val(tt22.Text)
            invdet1 = (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
            ' Should check for 0 determinant


            adj.Text = invdet1.ToString()

            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                MessageBox.Show("Cannot Divide, Or fill up the Matrix")
            ElseIf (adj.Text = "0") Then
                MessageBox.Show("Cannot Divide")

            Else


                ss0 = Val(tt1.Text) * Val(tt12.Text) - Val(tt11.Text) * Val(tt2.Text)
                ss1 = Val(tt1.Text) * Val(tt13.Text) - Val(tt11.Text) * Val(tt3.Text)
                ss2 = Val(tt1.Text) * Val(tt14.Text) - Val(tt11.Text) * Val(tt4.Text)
                ss3 = Val(tt2.Text) * Val(tt13.Text) - Val(tt12.Text) * Val(tt3.Text)
                ss4 = Val(tt2.Text) * Val(tt14.Text) - Val(tt12.Text) * Val(tt4.Text)
                ss5 = Val(tt3.Text) * Val(tt14.Text) - Val(tt13.Text) * Val(tt4.Text)

                c5 = Val(tt23.Text) * Val(tt34.Text) - Val(tt33.Text) * Val(tt24.Text)
                c4 = Val(tt22.Text) * Val(tt34.Text) - Val(tt32.Text) * Val(tt24.Text)
                c3 = Val(tt22.Text) * Val(tt33.Text) - Val(tt32.Text) * Val(tt23.Text)
                c2 = Val(tt21.Text) * Val(tt34.Text) - Val(tt31.Text) * Val(tt24.Text)
                c1 = Val(tt21.Text) * Val(tt33.Text) - Val(tt31.Text) * Val(tt23.Text)
                c0 = Val(tt21.Text) * Val(tt32.Text) - Val(tt31.Text) * Val(tt22.Text)
                ' Should check for 0 determinant



                invdet = 1 / (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
                adj.Text = invdet.ToString()
                i1 = (Val(tt12.Text) * c5 - Val(tt13.Text) * c4 + Val(tt14.Text) * c3) * invdet
                i2 = (-Val(tt2.Text) * c5 + Val(tt3.Text) * c4 - Val(tt4.Text) * c3) * invdet
                i3 = (Val(tt32.Text) * ss5 - Val(tt33.Text) * ss4 + Val(tt34.Text) * ss3) * invdet
                i4 = (-Val(tt22.Text) * ss5 + Val(tt23.Text) * ss4 - Val(tt24.Text) * ss3) * invdet

                i11 = (-Val(tt11.Text) * c5 + Val(tt13.Text) * c2 - Val(tt14.Text) * c1) * invdet
                i12 = (Val(tt1.Text) * c5 - Val(tt3.Text) * c2 + Val(tt4.Text) * c1) * invdet
                i13 = (-Val(tt31.Text) * ss5 + Val(tt33.Text) * ss2 - Val(tt34.Text) * ss1) * invdet
                i14 = (Val(tt21.Text) * ss5 - Val(tt23.Text) * ss2 + Val(tt24.Text) * ss1) * invdet

                i21 = (Val(tt11.Text) * c4 - Val(tt12.Text) * c2 + Val(tt14.Text) * c0) * invdet
                i22 = (-Val(tt1.Text) * c4 + Val(tt2.Text) * c2 - Val(tt4.Text) * c0) * invdet
                i23 = (Val(tt31.Text) * ss4 - Val(tt32.Text) * ss2 + Val(tt34.Text) * ss0) * invdet
                i24 = (-Val(tt21.Text) * ss4 + Val(tt22.Text) * ss2 - Val(tt24.Text) * ss0) * invdet

                i31 = (-Val(tt11.Text) * c3 + Val(tt12.Text) * c1 - Val(tt13.Text) * c0) * invdet
                i32 = (Val(tt1.Text) * c3 - Val(tt2.Text) * c1 + Val(tt3.Text) * c0) * invdet
                i33 = (-Val(tt31.Text) * ss3 + Val(tt32.Text) * ss1 - Val(tt33.Text) * ss0) * invdet
                i34 = (Val(tt21.Text) * ss3 - Val(tt22.Text) * ss1 + Val(tt23.Text) * ss0) * invdet

                in1 = i1
                in2 = i2
                in3 = i3
                in4 = i4
                in11 = i11
                in12 = i12
                in13 = i13
                in14 = i14
                in21 = i21
                in22 = i22
                in23 = i23
                in24 = i24
                in31 = i31
                in32 = i32
                in33 = i33
                in34 = i34

                a = Val(t1.Text) * in1 + Val(t2.Text) * in11 + Val(t3.Text) * in21 + Val(t4.Text) * in31
                b = Val(t1.Text) * in2 + Val(t2.Text) * in12 + Val(t3.Text) * in22 + Val(t4.Text) * in32
                j = Val(t1.Text) * in3 + Val(t2.Text) * in13 + Val(t3.Text) * in23 + Val(t4.Text) * in33
                n = Val(t1.Text) * in4 + Val(t2.Text) * in14 + Val(t3.Text) * in24 + Val(t4.Text) * in34

                c = Val(t11.Text) * in1 + Val(t12.Text) * in11 + Val(t13.Text) * in21 + Val(t14.Text) * in31
                d = Val(t11.Text) * in2 + Val(t12.Text) * in12 + Val(t13.Text) * in22 + Val(t14.Text) * in32
                k = Val(t11.Text) * in3 + Val(t12.Text) * in13 + Val(t13.Text) * in23 + Val(t14.Text) * in33
                o = Val(t11.Text) * in4 + Val(t12.Text) * in14 + Val(t13.Text) * in24 + Val(t14.Text) * in34

                f = Val(t21.Text) * in1 + Val(t22.Text) * in11 + Val(t23.Text) * in21 + Val(t24.Text) * in31
                g = Val(t21.Text) * in2 + Val(t22.Text) * in12 + Val(t23.Text) * in22 + Val(t24.Text) * in32
                l = Val(t21.Text) * in3 + Val(t22.Text) * in13 + Val(t23.Text) * in23 + Val(t24.Text) * in33
                p = Val(t21.Text) * in4 + Val(t22.Text) * in14 + Val(t23.Text) * in24 + Val(t24.Text) * in34

                h = Val(t31.Text) * in1 + Val(t32.Text) * in11 + Val(t33.Text) * in21 + Val(t34.Text) * in31
                i = Val(t31.Text) * in2 + Val(t32.Text) * in12 + Val(t33.Text) * in22 + Val(t34.Text) * in32
                m = Val(t31.Text) * in3 + Val(t32.Text) * in13 + Val(t33.Text) * in23 + Val(t34.Text) * in33
                q = Val(t31.Text) * in4 + Val(t32.Text) * in14 + Val(t33.Text) * in24 + Val(t34.Text) * in34

                String.Format("N5")
                s1.Text = t1.Text + "x" + in1.ToString("N3") + "+" + t2.Text + "x" + in11.ToString("N3") + "+" + t3.Text + "x" + in21.ToString("N3") + "+" + t4.Text + "x" + in31.ToString("N3") + "= " + a.ToString("N3")
                s2.Text = t1.Text + "x" + in2.ToString("N3") + "+" + t2.Text + "x" + in12.ToString("N3") + "+" + t3.Text + "x" + in22.ToString("N3") + "+" + t4.Text + "x" + in32.ToString("N3") + "= " + b.ToString("N3")
                s3.Text = t1.Text + "x" + in3.ToString("N3") + "+" + t2.Text + "x" + in13.ToString("N3") + "+" + t3.Text + "x" + in23.ToString("N3") + "+" + t4.Text + "x" + in33.ToString("N3") + "= " + j.ToString("N3")
                s4.Text = t1.Text + "x" + in4.ToString("N3") + "+" + t2.Text + "x" + in14.ToString("N3") + "+" + t3.Text + "x" + in24.ToString("N3") + "+" + t4.Text + "x" + in34.ToString("N3") + "= " + n.ToString("N3")
                s11.Text = t11.Text + "x" + in1.ToString("N3") + "+" + t12.Text + "x" + in11.ToString("N3") + "+" + t13.Text + "x" + in21.ToString("N3") + "+" + t14.Text + "x" + in31.ToString("N3") + "= " + c.ToString("N3")
                s12.Text = t11.Text + "x" + in2.ToString("N3") + "+" + t12.Text + "x" + in12.ToString("N3") + "+" + t13.Text + "x" + in22.ToString("N3") + "+" + t14.Text + "x" + in32.ToString("N3") + "=" + d.ToString("N3")
                s13.Text = t11.Text + "x" + in3.ToString("N3") + "+" + t12.Text + "x" + in13.ToString("N3") + "+" + t13.Text + "x" + in23.ToString("N3") + "+" + t14.Text + "x" + in33.ToString("N3") + "=" + k.ToString("N3")
                s14.Text = t11.Text + "x" + in4.ToString("N3") + "+" + t12.Text + "x" + in14.ToString("N3") + "+" + t13.Text + "x" + in24.ToString("N3") + "+" + t14.Text + "x" + in34.ToString("N3") + "=" + o.ToString("N3")
                s21.Text = t21.Text + "x" + in1.ToString("N3") + "+" + t22.Text + "x" + in11.ToString("N3") + "+" + t23.Text + "x" + in21.ToString("N3") + "+" + t24.Text + "x" + in31.ToString("N3") + "= " + f.ToString("N3")
                s22.Text = t21.Text + "x" + in2.ToString("N3") + "+" + t22.Text + "x" + in12.ToString("N3") + "+" + t23.Text + "x" + in22.ToString("N3") + "+" + t24.Text + "x" + in32.ToString("N3") + "=" + g.ToString("N3")
                s23.Text = t21.Text + "x" + in3.ToString("N3") + "+" + t22.Text + "x" + in13.ToString("N3") + "+" + t23.Text + "x" + in23.ToString("N3") + "+" + t24.Text + "x" + in33.ToString("N3") + "=" + l.ToString("N3")
                s24.Text = t21.Text + "x" + in4.ToString("N3") + "+" + t22.Text + "x" + in14.ToString("N3") + "+" + t23.Text + "x" + in24.ToString("N3") + "+" + t24.Text + "x" + in34.ToString("N3") + "=" + p.ToString("N3")
                s31.Text = t31.Text + "x" + in1.ToString("N3") + "+" + t32.Text + "x" + in11.ToString("N3") + "+" + t33.Text + "x" + in21.ToString("N3") + "+" + t34.Text + "x" + in31.ToString("N3") + "= " + h.ToString("N3")
                s32.Text = t31.Text + "x" + in2.ToString("N3") + "+" + t32.Text + "x" + in12.ToString("N3") + "+" + t33.Text + "x" + in22.ToString("N3") + "+" + t34.Text + "x" + in32.ToString("N3") + "=" + i.ToString("N3")
                s33.Text = t31.Text + "x" + in3.ToString("N3") + "+" + t32.Text + "x" + in13.ToString("N3") + "+" + t33.Text + "x" + in23.ToString("N3") + "+" + t34.Text + "x" + in33.ToString("N3") + "=" + m.ToString("N3")
                s34.Text = t31.Text + "x" + in4.ToString("N3") + "+" + t32.Text + "x" + in14.ToString("N3") + "+" + t33.Text + "x" + in24.ToString("N3") + "+" + t34.Text + "x" + in34.ToString("N3") + "=" + q.ToString("N3")
                a1.Text = a.ToString("N3")
                a2.Text = b.ToString("N3")
                a3.Text = j.ToString("N3")
                a4.Text = n.ToString("N3")
                a11.Text = c.ToString("N3")
                a12.Text = d.ToString("N3")
                a13.Text = k.ToString("N3")
                a14.Text = o.ToString("N3")
                a21.Text = f.ToString("N3")
                a22.Text = g.ToString("N3")
                a23.Text = l.ToString("N3")
                a24.Text = p.ToString("N3")
                a31.Text = h.ToString("N3")
                a32.Text = i.ToString("N3")
                a33.Text = m.ToString("N3")
                a34.Text = q.ToString("N3")

                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = True

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = True

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = True

                s31.Visible = True
                s32.Visible = True
                s33.Visible = True
                s34.Visible = True

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True
            End If


        ElseIf (cb1.SelectedItem = "2x2" And cb2.SelectedItem = "2x2") Then

            ad = (Val(tt1.Text) * Val(tt12.Text)) - (Val(tt2.Text) * Val(tt11.Text))
            adj.Text = ad.ToString()

            If (adj.Text = "0") Then
                '2x2



                MessageBox.Show("Cannot Divide")



            ElseIf (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then

                MessageBox.Show("fill up the Matrix!")

            Else


                ad = (Val(tt1.Text) * Val(tt12.Text)) - (Val(tt2.Text) * Val(tt11.Text))
                add = 1
                adj.Text = ad.ToString()
                in1 = add / (ad) * Val(tt12.Text)
                in2 = add / (ad) * (-Val(tt2.Text))
                in11 = add / (ad) * (-Val(tt11.Text))
                in12 = add / (ad) * (Val(tt1.Text))
                a = Val(t1.Text) * in1 + Val(t2.Text) * in11
                b = Val(t1.Text) * in2 + Val(t2.Text) * in12
                c = Val(t11.Text) * in1 + Val(t12.Text) * in11
                d = Val(t11.Text) * in2 + Val(t12.Text) * in12


                s1.Text = t1.Text + "x" + in1.ToString("N3") + "+" + t2.Text + "x" + in11.ToString("N3") + "= " + a.ToString("N3")
                s2.Text = t1.Text + "x" + in2.ToString("N3") + "+" + t2.Text + "x" + in12.ToString("N3") + "= " + b.ToString("N3")
                s11.Text = t11.Text + "x" + in1.ToString("N3") + "+" + t12.Text + "x" + in11.ToString("N3") + "= " + c.ToString("N3")
                s12.Text = t11.Text + "x" + in1.ToString("N3") + "+" + t12.Text + "x" + in12.ToString("N3") + "=" + d.ToString("N3")
                String.Format("N5")
                a1.Text = a.ToString("N3")
                a2.Text = b.ToString("N3")
                a11.Text = c.ToString("N3")
                a12.Text = d.ToString("N3")


                s1.Visible = True
                s2.Visible = True
                s3.Visible = False
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = "3x3" And cb2.SelectedItem = "3x3") Then
            ad = Val(tt1.Text) * (Val(tt12.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt22.Text)) - Val(tt2.Text) * (Val(tt11.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt21.Text)) + Val(tt3.Text) * (Val(tt11.Text) * Val(tt22.Text) - Val(tt12.Text) * Val(tt21.Text))
            adj.Text = ad.ToString()
            If (adj.Text = "0") Then

                MessageBox.Show("Cannot Divide")
                adj.Clear()




            ElseIf (tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "") Then

                MessageBox.Show("Fill up the Matrix!")


            Else



                ad = Val(tt1.Text) * (Val(tt12.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt22.Text)) - Val(tt2.Text) * (Val(tt11.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt21.Text)) + Val(tt3.Text) * (Val(tt11.Text) * Val(tt22.Text) - Val(tt12.Text) * Val(tt21.Text))
                add = 1
                adj1 = +(Val(tt12.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt22.Text))
                adj2 = -(Val(tt11.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt21.Text))
                adj3 = +(Val(tt11.Text) * Val(tt22.Text) - Val(tt12.Text) * Val(tt21.Text))
                adj11 = -(Val(tt2.Text) * Val(tt23.Text) - Val(tt3.Text) * Val(tt22.Text))
                adj12 = +(Val(tt1.Text) * Val(tt23.Text) - Val(tt3.Text) * Val(tt21.Text))
                adj13 = -(Val(tt1.Text) * Val(tt22.Text) - Val(tt2.Text) * Val(tt21.Text))
                adj21 = +(Val(tt2.Text) * Val(tt13.Text) - Val(tt3.Text) * Val(tt12.Text))
                adj22 = -(Val(tt1.Text) * Val(tt13.Text) - Val(tt3.Text) * Val(tt11.Text))
                adj23 = +(Val(tt1.Text) * Val(tt12.Text) - Val(tt2.Text) * Val(tt11.Text))
                adj.Text = ad.ToString()



                in1 = add / (ad) * adj1
                in2 = add / (ad) * adj11
                in3 = add / (ad) * adj21
                in11 = add / (ad) * adj2
                in12 = add / (ad) * adj12
                in13 = add / (ad) * adj22
                in21 = add / (ad) * adj3
                in22 = add / (ad) * adj13
                in23 = add / (ad) * adj23
                a = Val(t1.Text) * in1 + Val(t2.Text) * in11 + Val(t3.Text) * in21
                b = Val(t1.Text) * in2 + Val(t2.Text) * in12 + Val(t3.Text) * in22
                h = Val(t1.Text) * in3 + Val(t2.Text) * in13 + Val(t3.Text) * in23
                c = Val(t11.Text) * in1 + Val(t12.Text) * in11 + Val(t13.Text) * in21
                d = Val(t11.Text) * in2 + Val(t12.Text) * in12 + Val(t13.Text) * in22
                i = Val(t11.Text) * in3 + Val(t12.Text) * in13 + Val(t13.Text) * in23
                f = Val(t21.Text) * in1 + Val(t22.Text) * in11 + Val(t23.Text) * in21
                g = Val(t21.Text) * in2 + Val(t22.Text) * in12 + Val(t23.Text) * in22
                j = Val(t21.Text) * in3 + Val(t22.Text) * in13 + Val(t23.Text) * in23

                s1.Text = t1.Text + "x" + in1.ToString("N3") + "+" + t2.Text + "x" + in11.ToString("N3") + "+" + t3.Text + "x" + in21.ToString("N3") + "= " + a.ToString("N3")
                s2.Text = t1.Text + "x" + in2.ToString("N3") + "+" + t2.Text + "x" + in12.ToString("N3") + "+" + t3.Text + "x" + in22.ToString("N3") + "= " + b.ToString("N3")
                s3.Text = t1.Text + "x" + in3.ToString("N3") + "+" + t2.Text + "x" + in13.ToString("N3") + "+" + t3.Text + "x" + in23.ToString("N3") + "= " + h.ToString("N3")
                s11.Text = t11.Text + "x" + in1.ToString("N3") + "+" + t12.Text + "x" + in11.ToString("N3") + "+" + t13.Text + "x" + in21.ToString("N3") + "= " + c.ToString("N3")
                s12.Text = t11.Text + "x" + in2.ToString("N3") + "+" + t12.Text + "x" + in12.ToString("N3") + "+" + t13.Text + "x" + in22.ToString("N3") + "= " + d.ToString("N3")
                s13.Text = t11.Text + "x" + in3.ToString("N3") + "+" + t12.Text + "x" + in13.ToString("N3") + "+" + t13.Text + "x" + in23.ToString("N3") + "= " + i.ToString("N3")
                s21.Text = t21.Text + "x" + in1.ToString("N3") + "+" + t22.Text + "x" + in11.ToString("N3") + "+" + t23.Text + "x" + in21.ToString("N3") + "= " + f.ToString("N3")
                s22.Text = t21.Text + "x" + in2.ToString("N3") + "+" + t22.Text + "x" + in12.ToString("N3") + "+" + t23.Text + "x" + in22.ToString("N3") + "=" + g.ToString("N3")
                s23.Text = t21.Text + "x" + in3.ToString("N3") + "+" + t22.Text + "x" + in1.ToString("N3") + "+" + t23.Text + "x" + in23.ToString("N3") + "=" + j.ToString("N3")
                String.Format("N5")

                a1.Text = a.ToString("N3")
                a2.Text = b.ToString("N3")
                a3.Text = h.ToString("N3")
                a11.Text = c.ToString("N3")
                a12.Text = d.ToString("N3")
                a13.Text = i.ToString("N3")
                a21.Text = f.ToString("N3")
                a22.Text = g.ToString("N3")
                a23.Text = j.ToString("N3")
                s1.Visible = True
                s2.Visible = True
                s3.Visible = True
                s4.Visible = False

                s11.Visible = True
                s12.Visible = True
                s13.Visible = True
                s14.Visible = False

                s21.Visible = True
                s22.Visible = True
                s23.Visible = True
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False

            End If

        ElseIf (cb1.SelectedItem = Nothing Or cb2.SelectedItem = Nothing) Then

            MessageBox.Show("Please select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Invalid! Matrix should be same Dimension and Sqaure!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Division



    End Sub 'Division

    Private Sub invA_Click(sender As Object, e As EventArgs) Handles invA.Click

        Dim ss0, ss1, ss2, ss3, ss4, ss5, c0, c1, c2, c3, c4, c5 As Decimal
        Dim invdet, invdet1, ad, add, i1, i2, i3, i4, i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34 As Decimal
        Dim in1, in2, in3, in4, in11, in12, in13, in14, in21, in22, in23, in24, in31, in32, in33, in34 As Decimal
        Dim adj1, adj2, adj3, adj11, adj12, adj13, adj21, adj22, adj23 As Decimal
        invdet.ToString()
        If (cb1.SelectedItem = "4x4") Then
            '4x4 / 4x4

            ss0 = Val(t1.Text) * Val(t12.Text) - Val(t11.Text) * Val(t2.Text)
            ss1 = Val(t1.Text) * Val(t13.Text) - Val(t11.Text) * Val(t3.Text)
            ss2 = Val(t1.Text) * Val(t14.Text) - Val(t11.Text) * Val(t4.Text)
            ss3 = Val(t2.Text) * Val(t13.Text) - Val(t12.Text) * Val(t3.Text)
            ss4 = Val(t2.Text) * Val(t14.Text) - Val(t12.Text) * Val(t4.Text)
            ss5 = Val(t3.Text) * Val(t14.Text) - Val(t13.Text) * Val(t4.Text)

            c5 = Val(t23.Text) * Val(t34.Text) - Val(t33.Text) * Val(t24.Text)
            c4 = Val(t22.Text) * Val(t34.Text) - Val(t32.Text) * Val(t24.Text)
            c3 = Val(t22.Text) * Val(t33.Text) - Val(t32.Text) * Val(t23.Text)
            c2 = Val(t21.Text) * Val(t34.Text) - Val(t31.Text) * Val(t24.Text)
            c1 = Val(t21.Text) * Val(t33.Text) - Val(t31.Text) * Val(t23.Text)
            c0 = Val(t21.Text) * Val(t32.Text) - Val(t31.Text) * Val(t22.Text)
            invdet1 = (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
            ' Should check for 0 determinant


            adj.Text = invdet1.ToString()
            If (t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "" Or t24.Text = "" Or t31.Text = "" Or t32.Text = "" Or t33.Text = "" Or t34.Text = "") Then

                MessageBox.Show("fill up the Matrix")
            ElseIf (adj.Text = "0") Then
                MessageBox.Show("Cannot Inverse")
            Else
                ss0 = Val(t1.Text) * Val(t12.Text) - Val(t11.Text) * Val(t2.Text)
                ss1 = Val(t1.Text) * Val(t13.Text) - Val(t11.Text) * Val(t3.Text)
                ss2 = Val(t1.Text) * Val(t14.Text) - Val(t11.Text) * Val(t4.Text)
                ss3 = Val(t2.Text) * Val(t13.Text) - Val(t12.Text) * Val(t3.Text)
                ss4 = Val(t2.Text) * Val(t14.Text) - Val(t12.Text) * Val(t4.Text)
                ss5 = Val(t3.Text) * Val(t14.Text) - Val(t13.Text) * Val(t4.Text)

                c5 = Val(t23.Text) * Val(t34.Text) - Val(t33.Text) * Val(t24.Text)
                c4 = Val(t22.Text) * Val(t34.Text) - Val(t32.Text) * Val(t24.Text)
                c3 = Val(t22.Text) * Val(t33.Text) - Val(t32.Text) * Val(t23.Text)
                c2 = Val(t21.Text) * Val(t34.Text) - Val(t31.Text) * Val(t24.Text)
                c1 = Val(t21.Text) * Val(t33.Text) - Val(t31.Text) * Val(t23.Text)
                c0 = Val(t21.Text) * Val(t32.Text) - Val(t31.Text) * Val(t22.Text)
                invdet1 = (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
                invdet = 1 / (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
                adj.Text = invdet.ToString()
                i1 = (Val(t12.Text) * c5 - Val(t13.Text) * c4 + Val(t14.Text) * c3) * invdet
                i2 = (-Val(t2.Text) * c5 + Val(t3.Text) * c4 - Val(t4.Text) * c3) * invdet
                i3 = (Val(t32.Text) * ss5 - Val(t33.Text) * ss4 + Val(t34.Text) * ss3) * invdet
                i4 = (-Val(t22.Text) * ss5 + Val(t23.Text) * ss4 - Val(t24.Text) * ss3) * invdet

                i11 = (-Val(t11.Text) * c5 + Val(t13.Text) * c2 - Val(t14.Text) * c1) * invdet
                i12 = (Val(t1.Text) * c5 - Val(t3.Text) * c2 + Val(t4.Text) * c1) * invdet
                i13 = (-Val(t31.Text) * ss5 + Val(t33.Text) * ss2 - Val(t34.Text) * ss1) * invdet
                i14 = (Val(t21.Text) * ss5 - Val(t23.Text) * ss2 + Val(t24.Text) * ss1) * invdet

                i21 = (Val(t11.Text) * c4 - Val(t12.Text) * c2 + Val(t14.Text) * c0) * invdet
                i22 = (-Val(t1.Text) * c4 + Val(t2.Text) * c2 - Val(t4.Text) * c0) * invdet
                i23 = (Val(t31.Text) * ss4 - Val(t32.Text) * ss2 + Val(t34.Text) * ss0) * invdet
                i24 = (-Val(t21.Text) * ss4 + Val(t22.Text) * ss2 - Val(t24.Text) * ss0) * invdet

                i31 = (-Val(t11.Text) * c3 + Val(t12.Text) * c1 - Val(t13.Text) * c0) * invdet
                i32 = (Val(t1.Text) * c3 - Val(t2.Text) * c1 + Val(t3.Text) * c0) * invdet
                i33 = (-Val(t31.Text) * ss3 + Val(t32.Text) * ss1 - Val(t33.Text) * ss0) * invdet
                i34 = (Val(t21.Text) * ss3 - Val(t22.Text) * ss1 + Val(t23.Text) * ss0) * invdet
                in1 = i1
                in2 = i2
                in3 = i3
                in4 = i4
                in11 = i11
                in12 = i12
                in13 = i13
                in14 = i14
                in21 = i21
                in22 = i22
                in23 = i23
                in24 = i24
                in31 = i31
                in32 = i32
                in33 = i33
                in34 = i34
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a3.Text = in3.ToString("N3")
                a4.Text = in4.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                a13.Text = in13.ToString("N3")
                a14.Text = in14.ToString("N3")
                a21.Text = in21.ToString("N3")
                a22.Text = in22.ToString("N3")
                a23.Text = in23.ToString("N3")
                a24.Text = in24.ToString("N3")
                a31.Text = in31.ToString("N3")
                a32.Text = in32.ToString("N3")
                a33.Text = in33.ToString("N3")
                a34.Text = in34.ToString("N3")

                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True
            End If
        ElseIf (cb1.SelectedItem = "2x2") Then

            ad = (Val(t1.Text) * Val(t12.Text)) - (Val(t2.Text) * Val(t11.Text))
            adj.Text = ad.ToString()
            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "") Then
                MessageBox.Show("fill up the Matrix!")
            ElseIf (adj.Text = "0") Then
                '2x2



                MessageBox.Show("Cannot Inverse")

            Else
                ad = (Val(t1.Text) * Val(t12.Text)) - (Val(t2.Text) * Val(t11.Text))
                add = 1
                adj.Text = ad.ToString()
                in1 = (add / ad) * Val(t12.Text)
                in2 = (add / ad) * (-Val(t2.Text))
                in11 = (add / ad) * (-Val(t11.Text))
                in12 = (add / ad) * (Val(t1.Text))
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb1.SelectedItem = "3x3") Then
            ad = Val(t1.Text) * (Val(t12.Text) * Val(t23.Text) - Val(t13.Text) * Val(t22.Text)) - Val(t2.Text) * (Val(t11.Text) * Val(t23.Text) - Val(t13.Text) * Val(t21.Text)) + Val(t3.Text) * (Val(t11.Text) * Val(t22.Text) - Val(t12.Text) * Val(t21.Text))
            adj.Text = ad.ToString()

            If (t1.Text = "" Or t2.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t2.Text = "" Or t3.Text = "" Or t21.Text = "" Or t22.Text = "" Or t23.Text = "") Then
                MessageBox.Show("Fill up Matrix")


            ElseIf (adj.Text = "0") Then
                MessageBox.Show("Cannot Inverse")
            Else

                adj1 = +(Val(t12.Text) * Val(t23.Text) - Val(t13.Text) * Val(t22.Text))
                adj2 = -(Val(t11.Text) * Val(t23.Text) - Val(t13.Text) * Val(t21.Text))
                adj3 = +(Val(t11.Text) * Val(t22.Text) - Val(t12.Text) * Val(t21.Text))
                adj11 = -(Val(t2.Text) * Val(t23.Text) - Val(t3.Text) * Val(t22.Text))
                adj12 = +(Val(t1.Text) * Val(t23.Text) - Val(t3.Text) * Val(t21.Text))
                adj13 = -(Val(t1.Text) * Val(t22.Text) - Val(t2.Text) * Val(t21.Text))
                adj21 = +(Val(t2.Text) * Val(t13.Text) - Val(t3.Text) * Val(t12.Text))
                adj22 = -(Val(t1.Text) * Val(t13.Text) - Val(t3.Text) * Val(t11.Text))
                adj23 = +(Val(t1.Text) * Val(t12.Text) - Val(t2.Text) * Val(t11.Text))
                adj.Text = ad.ToString()

                add = 1

                in1 = add / (ad) * adj1
                in2 = add / (ad) * adj11
                in3 = add / (ad) * adj21
                in11 = add / (ad) * adj2
                in12 = add / (ad) * adj12
                in13 = add / (ad) * adj22
                in21 = add / (ad) * adj3
                in22 = add / (ad) * adj13
                in23 = add / (ad) * adj23
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a3.Text = in3.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                a13.Text = in13.ToString("N3")
                a21.Text = in21.ToString("N3")
                a22.Text = in22.ToString("N3")
                a23.Text = in23.ToString("N3")
                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False
                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb1.SelectedItem = Nothing) Then

            MessageBox.Show("Please select Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Invalid! columns and rows are EQUAL!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub 'Inverse A

    Private Sub invB_Click(sender As Object, e As EventArgs) Handles invB.Click

        Dim ss0, ss1, ss2, ss3, ss4, ss5, c0, c1, c2, c3, c4, c5 As Decimal
        Dim invdet, invdet1, ad, add, i1, i2, i3, i4, i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34 As Decimal
        Dim in1, in2, in3, in4, in11, in12, in13, in14, in21, in22, in23, in24, in31, in32, in33, in34 As Decimal
        Dim adj1, adj2, adj3, adj11, adj12, adj13, adj21, adj22, adj23 As Decimal
        invdet.ToString()
        If (cb2.SelectedItem = "4x4") Then
            '4x4 / 4x4

            ss0 = Val(tt1.Text) * Val(tt12.Text) - Val(tt11.Text) * Val(tt2.Text)
            ss1 = Val(tt1.Text) * Val(tt13.Text) - Val(tt11.Text) * Val(tt3.Text)
            ss2 = Val(tt1.Text) * Val(tt14.Text) - Val(tt11.Text) * Val(tt4.Text)
            ss3 = Val(tt2.Text) * Val(tt13.Text) - Val(tt12.Text) * Val(tt3.Text)
            ss4 = Val(tt2.Text) * Val(tt14.Text) - Val(tt12.Text) * Val(tt4.Text)
            ss5 = Val(tt3.Text) * Val(tt14.Text) - Val(tt13.Text) * Val(tt4.Text)

            c5 = Val(tt23.Text) * Val(tt34.Text) - Val(tt33.Text) * Val(tt24.Text)
            c4 = Val(tt22.Text) * Val(tt34.Text) - Val(tt32.Text) * Val(tt24.Text)
            c3 = Val(tt22.Text) * Val(tt33.Text) - Val(tt32.Text) * Val(tt23.Text)
            c2 = Val(tt21.Text) * Val(tt34.Text) - Val(tt31.Text) * Val(tt24.Text)
            c1 = Val(tt21.Text) * Val(tt33.Text) - Val(tt31.Text) * Val(tt23.Text)
            c0 = Val(tt21.Text) * Val(tt32.Text) - Val(tt31.Text) * Val(tt22.Text)
            invdet1 = (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
            ' Should check for 0 detterminantt


            adj.Text = invdet1.ToString()
            If (tt1.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt4.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt14.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "" Or tt24.Text = "" Or tt31.Text = "" Or tt32.Text = "" Or tt33.Text = "" Or tt34.Text = "") Then

                MessageBox.Show("fill up tthe Mattrix")
            ElseIf (adj.Text = "0") Then
                MessageBox.Show("Cannot Inverse")
            Else
                ss0 = Val(tt1.Text) * Val(tt12.Text) - Val(tt11.Text) * Val(tt2.Text)
                ss1 = Val(tt1.Text) * Val(tt13.Text) - Val(tt11.Text) * Val(tt3.Text)
                ss2 = Val(tt1.Text) * Val(tt14.Text) - Val(tt11.Text) * Val(tt4.Text)
                ss3 = Val(tt2.Text) * Val(tt13.Text) - Val(tt12.Text) * Val(tt3.Text)
                ss4 = Val(tt2.Text) * Val(tt14.Text) - Val(tt12.Text) * Val(tt4.Text)
                ss5 = Val(tt3.Text) * Val(tt14.Text) - Val(tt13.Text) * Val(tt4.Text)

                c5 = Val(tt23.Text) * Val(tt34.Text) - Val(tt33.Text) * Val(tt24.Text)
                c4 = Val(tt22.Text) * Val(tt34.Text) - Val(tt32.Text) * Val(tt24.Text)
                c3 = Val(tt22.Text) * Val(tt33.Text) - Val(tt32.Text) * Val(tt23.Text)
                c2 = Val(tt21.Text) * Val(tt34.Text) - Val(tt31.Text) * Val(tt24.Text)
                c1 = Val(tt21.Text) * Val(tt33.Text) - Val(tt31.Text) * Val(tt23.Text)
                c0 = Val(tt21.Text) * Val(tt32.Text) - Val(tt31.Text) * Val(tt22.Text)
                invdet1 = (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
                invdet = 1 / (ss0 * c5 - ss1 * c4 + ss2 * c3 + ss3 * c2 - ss4 * c1 + ss5 * c0)
                adj.Text = invdet.ToString()
                i1 = (Val(tt12.Text) * c5 - Val(tt13.Text) * c4 + Val(tt14.Text) * c3) * invdet
                i2 = (-Val(tt2.Text) * c5 + Val(tt3.Text) * c4 - Val(tt4.Text) * c3) * invdet
                i3 = (Val(tt32.Text) * ss5 - Val(tt33.Text) * ss4 + Val(tt34.Text) * ss3) * invdet
                i4 = (-Val(tt22.Text) * ss5 + Val(tt23.Text) * ss4 - Val(tt24.Text) * ss3) * invdet

                i11 = (-Val(tt11.Text) * c5 + Val(tt13.Text) * c2 - Val(tt14.Text) * c1) * invdet
                i12 = (Val(tt1.Text) * c5 - Val(tt3.Text) * c2 + Val(tt4.Text) * c1) * invdet
                i13 = (-Val(tt31.Text) * ss5 + Val(tt33.Text) * ss2 - Val(tt34.Text) * ss1) * invdet
                i14 = (Val(tt21.Text) * ss5 - Val(tt23.Text) * ss2 + Val(tt24.Text) * ss1) * invdet

                i21 = (Val(tt11.Text) * c4 - Val(tt12.Text) * c2 + Val(tt14.Text) * c0) * invdet
                i22 = (-Val(tt1.Text) * c4 + Val(tt2.Text) * c2 - Val(tt4.Text) * c0) * invdet
                i23 = (Val(tt31.Text) * ss4 - Val(tt32.Text) * ss2 + Val(tt34.Text) * ss0) * invdet
                i24 = (-Val(tt21.Text) * ss4 + Val(tt22.Text) * ss2 - Val(tt24.Text) * ss0) * invdet

                i31 = (-Val(tt11.Text) * c3 + Val(tt12.Text) * c1 - Val(tt13.Text) * c0) * invdet
                i32 = (Val(tt1.Text) * c3 - Val(tt2.Text) * c1 + Val(tt3.Text) * c0) * invdet
                i33 = (-Val(tt31.Text) * ss3 + Val(tt32.Text) * ss1 - Val(tt33.Text) * ss0) * invdet
                i34 = (Val(tt21.Text) * ss3 - Val(tt22.Text) * ss1 + Val(tt23.Text) * ss0) * invdet
                in1 = i1
                in2 = i2
                in3 = i3
                in4 = i4
                in11 = i11
                in12 = i12
                in13 = i13
                in14 = i14
                in21 = i21
                in22 = i22
                in23 = i23
                in24 = i24
                in31 = i31
                in32 = i32
                in33 = i33
                in34 = i34
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a3.Text = in3.ToString("N3")
                a4.Text = in4.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                a13.Text = in13.ToString("N3")
                a14.Text = in14.ToString("N3")
                a21.Text = in21.ToString("N3")
                a22.Text = in22.ToString("N3")
                a23.Text = in23.ToString("N3")
                a24.Text = in24.ToString("N3")
                a31.Text = in31.ToString("N3")
                a32.Text = in32.ToString("N3")
                a33.Text = in33.ToString("N3")
                a34.Text = in34.ToString("N3")

                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = True

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = True

                a31.Visible = True
                a32.Visible = True
                a33.Visible = True
                a34.Visible = True
            End If
        ElseIf (cb2.SelectedItem = "2x2") Then

            ad = (Val(tt1.Text) * Val(tt12.Text)) - (Val(tt2.Text) * Val(tt11.Text))
            adj.Text = ad.ToString()
            If (tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "") Then
                MessageBox.Show("fill up tthe Mattrix!")
            ElseIf (adj.Text = "0") Then

                MessageBox.Show("Cannot Inverse")

            Else
                ad = (Val(tt1.Text) * Val(tt12.Text)) - (Val(tt2.Text) * Val(tt11.Text))
                add = 1
                adj.Text = ad.ToString()
                in1 = (add / ad) * Val(tt12.Text)
                in2 = (add / ad) * (-Val(tt2.Text))
                in11 = (add / ad) * (-Val(tt11.Text))
                in12 = (add / ad) * (Val(tt1.Text))
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = False
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = False
                a14.Visible = False

                a21.Visible = False
                a22.Visible = False
                a23.Visible = False
                a24.Visible = False

                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If
        ElseIf (cb2.SelectedItem = "3x3") Then
            ad = Val(tt1.Text) * (Val(tt12.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt22.Text)) - Val(tt2.Text) * (Val(tt11.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt21.Text)) + Val(tt3.Text) * (Val(tt11.Text) * Val(tt22.Text) - Val(tt12.Text) * Val(tt21.Text))
            adj.Text = ad.ToString()

            If (tt1.Text = "" Or tt2.Text = "" Or tt11.Text = "" Or tt12.Text = "" Or tt13.Text = "" Or tt2.Text = "" Or tt3.Text = "" Or tt21.Text = "" Or tt22.Text = "" Or tt23.Text = "") Then
                MessageBox.Show("Fill up Mattrix")


            ElseIf (adj.Text = "0") Then
                MessageBox.Show("Cannot Inverse")
            Else

                adj1 = +(Val(tt12.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt22.Text))
                adj2 = -(Val(tt11.Text) * Val(tt23.Text) - Val(tt13.Text) * Val(tt21.Text))
                adj3 = +(Val(tt11.Text) * Val(tt22.Text) - Val(tt12.Text) * Val(tt21.Text))
                adj11 = -(Val(tt2.Text) * Val(tt23.Text) - Val(tt3.Text) * Val(tt22.Text))
                adj12 = +(Val(tt1.Text) * Val(tt23.Text) - Val(tt3.Text) * Val(tt21.Text))
                adj13 = -(Val(tt1.Text) * Val(tt22.Text) - Val(tt2.Text) * Val(tt21.Text))
                adj21 = +(Val(tt2.Text) * Val(tt13.Text) - Val(tt3.Text) * Val(tt12.Text))
                adj22 = -(Val(tt1.Text) * Val(tt13.Text) - Val(tt3.Text) * Val(tt11.Text))
                adj23 = +(Val(tt1.Text) * Val(tt12.Text) - Val(tt2.Text) * Val(tt11.Text))
                adj.Text = ad.ToString()

                add = 1

                in1 = add / (ad) * adj1
                in2 = add / (ad) * adj11
                in3 = add / (ad) * adj21
                in11 = add / (ad) * adj2
                in12 = add / (ad) * adj12
                in13 = add / (ad) * adj22
                in21 = add / (ad) * adj3
                in22 = add / (ad) * adj13
                in23 = add / (ad) * adj23
                a1.Text = in1.ToString("N3")
                a2.Text = in2.ToString("N3")
                a3.Text = in3.ToString("N3")
                a11.Text = in11.ToString("N3")
                a12.Text = in12.ToString("N3")
                a13.Text = in13.ToString("N3")
                a21.Text = in21.ToString("N3")
                a22.Text = in22.ToString("N3")
                a23.Text = in23.ToString("N3")
                s1.Visible = False
                s2.Visible = False
                s3.Visible = False
                s4.Visible = False

                s11.Visible = False
                s12.Visible = False
                s13.Visible = False
                s14.Visible = False

                s21.Visible = False
                s22.Visible = False
                s23.Visible = False
                s24.Visible = False

                s31.Visible = False
                s32.Visible = False
                s33.Visible = False
                s34.Visible = False

                a1.Visible = True
                a2.Visible = True
                a3.Visible = True
                a4.Visible = False

                a11.Visible = True
                a12.Visible = True
                a13.Visible = True
                a14.Visible = False

                a21.Visible = True
                a22.Visible = True
                a23.Visible = True
                a24.Visible = False
                a31.Visible = False
                a32.Visible = False
                a33.Visible = False
                a34.Visible = False
            End If

        ElseIf (cb2.SelectedItem = Nothing) Then

            MessageBox.Show("Please selectt Row's and Column's", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            MessageBox.Show("Invalid! columns and rows are EQUAL!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub 'Inverse B

    Private Sub s34_TextChanged(sender As Object, e As EventArgs) Handles s34.TextChanged

    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub t11_TextChanged(sender As Object, e As EventArgs) Handles t11.TextChanged

    End Sub

    Private Sub t21_TextChanged(sender As Object, e As EventArgs) Handles t21.TextChanged

    End Sub

    Private Sub t31_TextChanged(sender As Object, e As EventArgs) Handles t31.TextChanged

    End Sub

    Private Sub t32_TextChanged(sender As Object, e As EventArgs) Handles t32.TextChanged

    End Sub

    Private Sub t22_TextChanged(sender As Object, e As EventArgs) Handles t22.TextChanged

    End Sub

    Private Sub t12_TextChanged(sender As Object, e As EventArgs) Handles t12.TextChanged

    End Sub

    Private Sub t2_TextChanged(sender As Object, e As EventArgs) Handles t2.TextChanged

    End Sub

    Private Sub t34_TextChanged(sender As Object, e As EventArgs) Handles t34.TextChanged

    End Sub

    Private Sub t24_TextChanged(sender As Object, e As EventArgs) Handles t24.TextChanged

    End Sub

    Private Sub t14_TextChanged(sender As Object, e As EventArgs) Handles t14.TextChanged

    End Sub

    Private Sub t4_TextChanged(sender As Object, e As EventArgs) Handles t4.TextChanged

    End Sub

    Private Sub t33_TextChanged(sender As Object, e As EventArgs) Handles t33.TextChanged

    End Sub

    Private Sub t23_TextChanged(sender As Object, e As EventArgs) Handles t23.TextChanged

    End Sub

    Private Sub t13_TextChanged(sender As Object, e As EventArgs) Handles t13.TextChanged

    End Sub

    Private Sub t3_TextChanged(sender As Object, e As EventArgs) Handles t3.TextChanged

    End Sub

    Private Sub tt34_TextChanged(sender As Object, e As EventArgs) Handles tt34.TextChanged

    End Sub

    Private Sub tt24_TextChanged(sender As Object, e As EventArgs) Handles tt24.TextChanged

    End Sub

    Private Sub tt14_TextChanged(sender As Object, e As EventArgs) Handles tt14.TextChanged

    End Sub

    Private Sub tt4_TextChanged(sender As Object, e As EventArgs) Handles tt4.TextChanged

    End Sub

    Private Sub tt33_TextChanged(sender As Object, e As EventArgs) Handles tt33.TextChanged

    End Sub

    Private Sub tt23_TextChanged(sender As Object, e As EventArgs) Handles tt23.TextChanged

    End Sub

    Private Sub tt13_TextChanged(sender As Object, e As EventArgs) Handles tt13.TextChanged

    End Sub

    Private Sub tt3_TextChanged(sender As Object, e As EventArgs) Handles tt3.TextChanged

    End Sub

    Private Sub tt32_TextChanged(sender As Object, e As EventArgs) Handles tt32.TextChanged

    End Sub

    Private Sub tt22_TextChanged(sender As Object, e As EventArgs) Handles tt22.TextChanged

    End Sub

    Private Sub tt12_TextChanged(sender As Object, e As EventArgs) Handles tt12.TextChanged

    End Sub

    Private Sub tt2_TextChanged(sender As Object, e As EventArgs) Handles tt2.TextChanged

    End Sub

    Private Sub tt31_TextChanged(sender As Object, e As EventArgs) Handles tt31.TextChanged

    End Sub

    Private Sub tt21_TextChanged(sender As Object, e As EventArgs) Handles tt21.TextChanged

    End Sub

    Private Sub tt11_TextChanged(sender As Object, e As EventArgs) Handles tt11.TextChanged

    End Sub

    Private Sub tt1_TextChanged(sender As Object, e As EventArgs) Handles tt1.TextChanged

    End Sub

    Private Sub s31_TextChanged(sender As Object, e As EventArgs) Handles s31.TextChanged

    End Sub

    Private Sub s21_TextChanged(sender As Object, e As EventArgs) Handles s21.TextChanged

    End Sub

    Private Sub s11_TextChanged(sender As Object, e As EventArgs) Handles s11.TextChanged

    End Sub

    Private Sub s1_TextChanged(sender As Object, e As EventArgs) Handles s1.TextChanged

    End Sub

    Private Sub s32_TextChanged(sender As Object, e As EventArgs) Handles s32.TextChanged

    End Sub

    Private Sub s22_TextChanged(sender As Object, e As EventArgs) Handles s22.TextChanged

    End Sub

    Private Sub s12_TextChanged(sender As Object, e As EventArgs) Handles s12.TextChanged

    End Sub

    Private Sub s2_TextChanged(sender As Object, e As EventArgs) Handles s2.TextChanged

    End Sub

    Private Sub s33_TextChanged(sender As Object, e As EventArgs) Handles s33.TextChanged

    End Sub

    Private Sub s23_TextChanged(sender As Object, e As EventArgs) Handles s23.TextChanged

    End Sub

    Private Sub s13_TextChanged(sender As Object, e As EventArgs) Handles s13.TextChanged

    End Sub

    Private Sub s3_TextChanged(sender As Object, e As EventArgs) Handles s3.TextChanged

    End Sub

    Private Sub s24_TextChanged(sender As Object, e As EventArgs) Handles s24.TextChanged

    End Sub

    Private Sub s14_TextChanged(sender As Object, e As EventArgs) Handles s14.TextChanged

    End Sub

    Private Sub s4_TextChanged(sender As Object, e As EventArgs) Handles s4.TextChanged

    End Sub

    Private Sub a34_TextChanged(sender As Object, e As EventArgs) Handles a34.TextChanged

    End Sub

    Private Sub a24_TextChanged(sender As Object, e As EventArgs) Handles a24.TextChanged

    End Sub

    Private Sub a14_TextChanged(sender As Object, e As EventArgs) Handles a14.TextChanged

    End Sub

    Private Sub a4_TextChanged(sender As Object, e As EventArgs) Handles a4.TextChanged

    End Sub

    Private Sub a33_TextChanged(sender As Object, e As EventArgs) Handles a33.TextChanged

    End Sub

    Private Sub a23_TextChanged(sender As Object, e As EventArgs) Handles a23.TextChanged

    End Sub

    Private Sub a13_TextChanged(sender As Object, e As EventArgs) Handles a13.TextChanged

    End Sub

    Private Sub a3_TextChanged(sender As Object, e As EventArgs) Handles a3.TextChanged

    End Sub

    Private Sub a32_TextChanged(sender As Object, e As EventArgs) Handles a32.TextChanged

    End Sub

    Private Sub a22_TextChanged(sender As Object, e As EventArgs) Handles a22.TextChanged

    End Sub

    Private Sub a12_TextChanged(sender As Object, e As EventArgs) Handles a12.TextChanged

    End Sub

    Private Sub a2_TextChanged(sender As Object, e As EventArgs) Handles a2.TextChanged

    End Sub

    Private Sub a31_TextChanged(sender As Object, e As EventArgs) Handles a31.TextChanged

    End Sub

    Private Sub a21_TextChanged(sender As Object, e As EventArgs) Handles a21.TextChanged

    End Sub

    Private Sub a11_TextChanged(sender As Object, e As EventArgs) Handles a11.TextChanged

    End Sub

    Private Sub a1_TextChanged(sender As Object, e As EventArgs) Handles a1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
End Class
