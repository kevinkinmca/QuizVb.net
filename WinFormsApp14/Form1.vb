Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "QUIZ"
        GroupBox1.Text = "Question:1"
        GroupBox2.Text = "Question:2"
        GroupBox3.Text = "Question:3"
        GroupBox4.Text = "Question:4"
        GroupBox5.Text = "Question:5"
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        Button1.Text = "Next"
        Button2.Text = "Next"
        Button3.Text = "Next"
        Button4.Text = "Next"
        Button5.Text = "Finish"
        Button6.Text = "START"


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = True
        Label2.Text = "What is the capital of France?"
        RadioButton1.Text = "A) Berlin"
        RadioButton2.Text = "B) Madrid"
        RadioButton3.Text = "C) Paris"
        RadioButton4.Text = "D) Rome"
        Button6.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Visible = True
        Label3.Text = "Which planet is known as the Red Planet?"
        RadioButton5.Text = "A) Venus "
        RadioButton6.Text = "B) Mars "
        RadioButton7.Text = "C) Jupiter "
        RadioButton8.Text = "D) Saturn"
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox3.Visible = True
        Label4.Text = "Who wrote the play ‘Romeo and Juliet’?"
        RadioButton9.Text = "A) William Shakespeare"
        RadioButton10.Text = "B) Charles Dickens"
        RadioButton11.Text = "C) Jane Austen"
        RadioButton12.Text = "D)  George Orwell"
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox4.Visible = True
        Label5.Text = "What is the largest mammal in the world?"
        RadioButton13.Text = "A) African Elephant"
        RadioButton14.Text = "B) Blue Whale"
        RadioButton15.Text = "C) Giraffe"
        RadioButton16.Text = "D) Polar Bear"
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox5.Visible = True
        Label6.Text = "Which element has the chemical symbol ‘O’?"
        RadioButton17.Text = "A) Gold"
        RadioButton18.Text = "B) Oxygen"
        RadioButton19.Text = "C) Iron"
        RadioButton20.Text = "D) Helium"
        Button4.Enabled = False
    End Sub
End Class
