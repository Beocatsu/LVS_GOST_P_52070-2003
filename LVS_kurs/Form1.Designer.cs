using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVSkurs
{
    public partial class Form1 : Form
    {
        LVS lvs;
        LVS test;
        bool gen;//есть ли генерация в сеансе
        bool[] defect = new bool[18];//максимум 1 дефект для каждого ОУ
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.button65 = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button68 = new System.Windows.Forms.Button();
            this.button69 = new System.Windows.Forms.Button();
            this.button70 = new System.Windows.Forms.Button();
            this.button71 = new System.Windows.Forms.Button();
            this.button72 = new System.Windows.Forms.Button();
            this.button73 = new System.Windows.Forms.Button();
            this.button74 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button76 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button77 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Для статического теста";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 29);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 29);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(161, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 29);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(211, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 29);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(246, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 29);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(325, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 29);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(360, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 29);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(410, 44);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 29);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(445, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 29);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(497, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 29);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(532, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 29);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(532, 73);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 29);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(497, 73);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 29);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(445, 73);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 29);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(410, 73);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 29);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(360, 73);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 29);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(325, 73);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 29);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(246, 73);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 29);
            this.button20.TabIndex = 19;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(211, 73);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 29);
            this.button21.TabIndex = 20;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(161, 73);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(35, 29);
            this.button22.TabIndex = 21;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(126, 73);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(35, 29);
            this.button23.TabIndex = 22;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(77, 73);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(35, 29);
            this.button24.TabIndex = 23;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(42, 73);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 29);
            this.button25.TabIndex = 24;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(246, 246);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(35, 29);
            this.button26.TabIndex = 25;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(211, 246);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(35, 29);
            this.button27.TabIndex = 26;
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(161, 246);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(35, 29);
            this.button28.TabIndex = 27;
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(126, 246);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(35, 29);
            this.button29.TabIndex = 28;
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(77, 246);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(35, 29);
            this.button30.TabIndex = 29;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(42, 246);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(35, 29);
            this.button31.TabIndex = 30;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(814, 73);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(35, 29);
            this.button32.TabIndex = 31;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(779, 73);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(35, 29);
            this.button33.TabIndex = 32;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(725, 73);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(35, 29);
            this.button34.TabIndex = 33;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(690, 73);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(35, 29);
            this.button35.TabIndex = 34;
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(638, 73);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(35, 29);
            this.button36.TabIndex = 35;
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(603, 73);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(35, 29);
            this.button37.TabIndex = 36;
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(246, 217);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(35, 29);
            this.button38.TabIndex = 37;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(211, 217);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(35, 29);
            this.button39.TabIndex = 38;
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(161, 217);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(35, 29);
            this.button40.TabIndex = 39;
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(126, 217);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(35, 29);
            this.button41.TabIndex = 40;
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(77, 217);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(35, 29);
            this.button42.TabIndex = 41;
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(42, 217);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(35, 29);
            this.button43.TabIndex = 42;
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(814, 44);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(35, 29);
            this.button44.TabIndex = 43;
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(779, 44);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(35, 29);
            this.button45.TabIndex = 44;
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(725, 44);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(35, 29);
            this.button46.TabIndex = 45;
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(690, 44);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(35, 29);
            this.button47.TabIndex = 46;
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(638, 44);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(35, 29);
            this.button48.TabIndex = 47;
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(603, 44);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(35, 29);
            this.button49.TabIndex = 48;
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(814, 246);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(35, 29);
            this.button50.TabIndex = 49;
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(779, 246);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(35, 29);
            this.button51.TabIndex = 50;
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(725, 246);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(35, 29);
            this.button52.TabIndex = 51;
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.button52_Click);
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(690, 246);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(35, 29);
            this.button53.TabIndex = 52;
            this.button53.UseVisualStyleBackColor = true;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(638, 246);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(35, 29);
            this.button54.TabIndex = 53;
            this.button54.UseVisualStyleBackColor = true;
            this.button54.Click += new System.EventHandler(this.button54_Click);
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(603, 246);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(35, 29);
            this.button55.TabIndex = 54;
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // button56
            // 
            this.button56.Location = new System.Drawing.Point(532, 246);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(35, 29);
            this.button56.TabIndex = 55;
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button57
            // 
            this.button57.Location = new System.Drawing.Point(497, 246);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(35, 29);
            this.button57.TabIndex = 56;
            this.button57.UseVisualStyleBackColor = true;
            this.button57.Click += new System.EventHandler(this.button57_Click);
            // 
            // button58
            // 
            this.button58.Location = new System.Drawing.Point(445, 246);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(35, 29);
            this.button58.TabIndex = 57;
            this.button58.UseVisualStyleBackColor = true;
            this.button58.Click += new System.EventHandler(this.button58_Click);
            // 
            // button59
            // 
            this.button59.Location = new System.Drawing.Point(410, 246);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(35, 29);
            this.button59.TabIndex = 58;
            this.button59.UseVisualStyleBackColor = true;
            this.button59.Click += new System.EventHandler(this.button59_Click);
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(360, 246);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(35, 29);
            this.button60.TabIndex = 59;
            this.button60.UseVisualStyleBackColor = true;
            this.button60.Click += new System.EventHandler(this.button60_Click);
            // 
            // button61
            // 
            this.button61.Location = new System.Drawing.Point(325, 246);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(35, 29);
            this.button61.TabIndex = 60;
            this.button61.UseVisualStyleBackColor = true;
            this.button61.Click += new System.EventHandler(this.button61_Click);
            // 
            // button62
            // 
            this.button62.Location = new System.Drawing.Point(814, 217);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(35, 29);
            this.button62.TabIndex = 61;
            this.button62.UseVisualStyleBackColor = true;
            this.button62.Click += new System.EventHandler(this.button62_Click);
            // 
            // button63
            // 
            this.button63.Location = new System.Drawing.Point(779, 217);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(35, 29);
            this.button63.TabIndex = 62;
            this.button63.UseVisualStyleBackColor = true;
            this.button63.Click += new System.EventHandler(this.button63_Click);
            // 
            // button64
            // 
            this.button64.Location = new System.Drawing.Point(725, 217);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(35, 29);
            this.button64.TabIndex = 63;
            this.button64.UseVisualStyleBackColor = true;
            // 
            // button65
            // 
            this.button65.Location = new System.Drawing.Point(690, 217);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(35, 29);
            this.button65.TabIndex = 64;
            this.button65.UseVisualStyleBackColor = true;
            this.button65.Click += new System.EventHandler(this.button65_Click);
            // 
            // button66
            // 
            this.button66.Location = new System.Drawing.Point(638, 217);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(35, 29);
            this.button66.TabIndex = 65;
            this.button66.UseVisualStyleBackColor = true;
            this.button66.Click += new System.EventHandler(this.button66_Click);
            // 
            // button67
            // 
            this.button67.Location = new System.Drawing.Point(603, 217);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(35, 29);
            this.button67.TabIndex = 66;
            this.button67.UseVisualStyleBackColor = true;
            this.button67.Click += new System.EventHandler(this.button67_Click);
            // 
            // button68
            // 
            this.button68.Location = new System.Drawing.Point(532, 217);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(35, 29);
            this.button68.TabIndex = 67;
            this.button68.UseVisualStyleBackColor = true;
            this.button68.Click += new System.EventHandler(this.button68_Click);
            // 
            // button69
            // 
            this.button69.Location = new System.Drawing.Point(497, 217);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(35, 29);
            this.button69.TabIndex = 68;
            this.button69.UseVisualStyleBackColor = true;
            this.button69.Click += new System.EventHandler(this.button69_Click);
            // 
            // button70
            // 
            this.button70.Location = new System.Drawing.Point(445, 217);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(35, 29);
            this.button70.TabIndex = 69;
            this.button70.UseVisualStyleBackColor = true;
            this.button70.Click += new System.EventHandler(this.button70_Click);
            // 
            // button71
            // 
            this.button71.Location = new System.Drawing.Point(410, 217);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(35, 29);
            this.button71.TabIndex = 70;
            this.button71.UseVisualStyleBackColor = true;
            this.button71.Click += new System.EventHandler(this.button71_Click);
            // 
            // button72
            // 
            this.button72.Location = new System.Drawing.Point(360, 217);
            this.button72.Name = "button72";
            this.button72.Size = new System.Drawing.Size(35, 29);
            this.button72.TabIndex = 71;
            this.button72.UseVisualStyleBackColor = true;
            this.button72.Click += new System.EventHandler(this.button72_Click);
            // 
            // button73
            // 
            this.button73.Location = new System.Drawing.Point(325, 217);
            this.button73.Name = "button73";
            this.button73.Size = new System.Drawing.Size(35, 29);
            this.button73.TabIndex = 72;
            this.button73.UseVisualStyleBackColor = true;
            this.button73.Click += new System.EventHandler(this.button73_Click);
            // 
            // button74
            // 
            this.button74.Location = new System.Drawing.Point(148, 305);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(135, 77);
            this.button74.TabIndex = 73;
            this.button74.Text = "Запуск с параметрами пользователя";
            this.button74.UseVisualStyleBackColor = true;
            this.button74.Click += new System.EventHandler(this.button74_Click);
            // 
            // button75
            // 
            this.button75.Location = new System.Drawing.Point(12, 305);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(126, 77);
            this.button75.TabIndex = 74;
            this.button75.Text = "Старт сети";
            this.button75.UseVisualStyleBackColor = true;
            this.button75.Click += new System.EventHandler(this.button75_Click);
            // 
            // button76
            // 
            this.button76.Location = new System.Drawing.Point(12, 113);
            this.button76.Name = "button76";
            this.button76.Size = new System.Drawing.Size(868, 32);
            this.button76.TabIndex = 75;
            this.button76.Text = "Линия А";
            this.button76.UseVisualStyleBackColor = true;
            this.button76.Click += new System.EventHandler(this.button76_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "ОУ1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "ОУ2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "ОУ3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "ОУ4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "ОУ5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "ОУ6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "ОУ7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(705, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "ОУ8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "ОУ9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "ОУ10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 87;
            this.label11.Text = "ОУ11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 88;
            this.label12.Text = "ОУ12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "ОУ13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(424, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "ОУ14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(510, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "ОУ15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(617, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 92;
            this.label16.Text = "ОУ16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(705, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 93;
            this.label17.Text = "ОУ17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(791, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 20);
            this.label18.TabIndex = 94;
            this.label18.Text = "ОУ18";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 305);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 160);
            this.richTextBox1.TabIndex = 95;
            this.richTextBox1.Text = "";
            // 
            // button77
            // 
            this.button77.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button77.Location = new System.Drawing.Point(12, 148);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(868, 32);
            this.button77.TabIndex = 76;
            this.button77.Text = "Линия В";
            this.button77.UseVisualStyleBackColor = true;
            this.button77.Click += new System.EventHandler(this.button77_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(896, 487);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button77);
            this.Controls.Add(this.button76);
            this.Controls.Add(this.button75);
            this.Controls.Add(this.button74);
            this.Controls.Add(this.button73);
            this.Controls.Add(this.button72);
            this.Controls.Add(this.button71);
            this.Controls.Add(this.button70);
            this.Controls.Add(this.button69);
            this.Controls.Add(this.button68);
            this.Controls.Add(this.button67);
            this.Controls.Add(this.button66);
            this.Controls.Add(this.button65);
            this.Controls.Add(this.button64);
            this.Controls.Add(this.button63);
            this.Controls.Add(this.button62);
            this.Controls.Add(this.button61);
            this.Controls.Add(this.button60);
            this.Controls.Add(this.button59);
            this.Controls.Add(this.button58);
            this.Controls.Add(this.button57);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        public Form1()
        {
            
            InitializeComponent();
            gen = false;
            for (int i = 0; i < 18; i++) { defect[i] = false; }
        }
        private void button1_Click(object sender, EventArgs e)//Статиcтический тест
        {
            richTextBox1.Text = "";
            test = new LVS(1);
            Random rand = new Random();
            test.working_20000(true, rand);
            richTextBox1.Text += test.sb.ToString();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != Color.Red)
            {
                button8.BackColor = Color.Red;
                button9.Enabled = false;
                button19.Enabled = false;
                button18.Enabled = false;
            }
            else
            {
                button8.BackColor = Color.Green;
                button9.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[3] == false) 
                { gen = true; defect[3] = true; button9.BackColor = Color.Blue; } }
            else if (button9.BackColor == Color.Blue) { if (defect[3] == true) 
                { gen = false; defect[3] = false; button9.BackColor = SystemColors.Control; } }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor != Color.Red)
            {
                button10.BackColor = Color.Red;
                button11.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.Green;
                button11.Enabled = true;
                button17.Enabled = true;
                button16.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != Color.Red)
            {
                button2.BackColor = Color.Red;
                button3.Enabled = false;
                button25.Enabled = false;
                button24.Enabled = false;
            }
            else
            {
                button2.BackColor = Color.Green;
                button3.Enabled = true;
                button25.Enabled = true;
                button24.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //генерация
            if (gen == false) { if (defect[0] == false) { gen = true; defect[0] = true; button3.BackColor = Color.Blue; } }
            else if (button3.BackColor == Color.Blue) { if (defect[0] == true) { gen = false; defect[0] = false; button3.BackColor = SystemColors.Control; } }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != Color.Red)
            {
                button4.BackColor = Color.Red;
                button5.Enabled = false;
                button23.Enabled = false;
                button22.Enabled = false;
            }
            else
            {
                button4.BackColor = Color.Green;
                button5.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[1] == false) { gen = true; defect[1] = true; button5.BackColor = Color.Blue; } }
            else if (button5.BackColor == Color.Blue) { if (defect[1] == true) { gen = false; defect[1] = false; button5.BackColor = SystemColors.Control; } }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor != Color.Red)
            {
                button6.BackColor = Color.Red;
                button7.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
            }
            else
            {
                button6.BackColor = Color.Green;
                button7.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[2] == false) 
                { gen = true; defect[2] = true; button7.BackColor = Color.Blue; } }
            else if (button7.BackColor == Color.Blue) if (defect[2] == true) 
                { gen = false; defect[2] = false; button7.BackColor = SystemColors.Control; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[4] == false) 
                { gen = true; defect[4] = true; button11.BackColor = Color.Blue; } }
            else if (button11.BackColor == Color.Blue) if (defect[4] == true) 
                { gen = false; defect[4] = false; button11.BackColor = SystemColors.Control; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor != Color.Red)
            {
                button12.BackColor = Color.Red;
                button13.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
            }
            else
            {
                button12.BackColor = Color.Green;
                button13.Enabled = true;
                button15.Enabled = true;
                button14.Enabled = true;
            }
        }

        private void button74_Click(object sender, EventArgs e)//обход 
        {
            //инициализация 
            richTextBox1.Text = "Запуск ЛВС" + '\n';
            lvs = new LVS(1, 18);
            if (button77.BackColor == Color.Green) richTextBox1.Text += "Активная линия B" + "\n";
            else richTextBox1.Text += "Активная линия A" + "\n";
            int[] t = new int[4];
            //ОУ1
            if (button2.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(0).Value.chState("blocked");
            }
            else if (button3.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(0).Value.chState("generator");
            }
            else if (button25.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(0).Value.chState("failure");
            }
            else if (button24.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(0).Value.chState("busy");
            }
            else lvs.clients.ElementAt(0).Value.chState("working");

            //ОУ2
            if (button4.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(1).Value.chState("blocked");
            }
            else if (button5.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(1).Value.chState("generator");
            }
            else if (button23.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(1).Value.chState("failure");
            }
            else if (button22.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(1).Value.chState("busy");
            }
            else lvs.clients.ElementAt(1).Value.chState("working");

            //ОУ3
            if (button6.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(2).Value.chState("blocked");
            }
            else if (button7.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(2).Value.chState("generator");
            }
            else if (button21.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(2).Value.chState("failure");
            }
            else if (button20.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(2).Value.chState("busy");
            }
            else lvs.clients.ElementAt(2).Value.chState("working");

            //ОУ4
            if (button8.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(3).Value.chState("blocked");
            }
            else if (button9.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(3).Value.chState("generator");
            }
            else if (button19.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(3).Value.chState("failure");
            }
            else if (button18.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(3).Value.chState("busy");
            }
            else lvs.clients.ElementAt(3).Value.chState("working");

            //ОУ5
            if (button10.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(4).Value.chState("blocked");
            }
            else if (button11.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(4).Value.chState("generator");
            }
            else if (button17.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(4).Value.chState("failure");
            }
            else if (button16.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(4).Value.chState("busy");
            }
            else lvs.clients.ElementAt(4).Value.chState("working");

            //ОУ6
            if (button12.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(5).Value.chState("blocked");
            }
            else if (button13.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(5).Value.chState("generator");
            }
            else if (button15.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(5).Value.chState("failure");
            }
            else if (button14.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(5).Value.chState("busy");
            }
            else lvs.clients.ElementAt(5).Value.chState("working");

            //ОУ7
            if (button49.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(6).Value.chState("blocked");
            }
            else if (button48.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(6).Value.chState("generator");
            }
            else if (button37.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(6).Value.chState("failure");
            }
            else if (button36.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(6).Value.chState("busy");
            }
            else lvs.clients.ElementAt(6).Value.chState("working");

            //ОУ8
            if (button47.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(7).Value.chState("blocked");
            }
            else if (button46.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(7).Value.chState("generator");
            }
            else if (button35.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(7).Value.chState("failure");
            }
            else if (button34.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(7).Value.chState("busy");
            }
            else lvs.clients.ElementAt(7).Value.chState("working");

            //ОУ9
            if (button45.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(8).Value.chState("blocked");
            }
            else if (button44.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(8).Value.chState("generator");
            }
            else if (button33.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(8).Value.chState("failure");
            }
            else if (button32.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(8).Value.chState("busy");
            }
            else lvs.clients.ElementAt(8).Value.chState("working");

            //ОУ10
            if (button43.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(9).Value.chState("blocked");
            }
            else if (button42.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(9).Value.chState("generator");
            }
            else if (button31.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(9).Value.chState("failure");
            }
            else if (button30.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(9).Value.chState("busy");
            }
            else lvs.clients.ElementAt(9).Value.chState("working");

            //ОУ11
            if (button41.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(10).Value.chState("blocked");
            }
            else if (button40.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(10).Value.chState("generator");
            }
            else if (button29.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(10).Value.chState("failure");
            }
            else if (button28.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(10).Value.chState("busy");
            }
            else lvs.clients.ElementAt(10).Value.chState("working");

            //ОУ12
            if (button39.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(11).Value.chState("blocked");
            }
            else if (button38.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(11).Value.chState("generator");
            }
            else if (button27.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(11).Value.chState("failure");
            }
            else if (button26.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(11).Value.chState("busy");
            }
            else lvs.clients.ElementAt(11).Value.chState("working");

            //ОУ13
            if (button73.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(12).Value.chState("blocked");
            }
            else if (button72.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(12).Value.chState("generator");
            }
            else if (button61.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(12).Value.chState("failure");
            }
            else if (button60.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(12).Value.chState("busy");
            }
            else lvs.clients.ElementAt(12).Value.chState("working");

            //ОУ14
            if (button71.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(13).Value.chState("blocked");
            }
            else if (button70.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(13).Value.chState("generator");
            }
            else if (button59.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(13).Value.chState("failure");
            }
            else if (button58.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(13).Value.chState("busy");
            }
            else lvs.clients.ElementAt(13).Value.chState("working");

            //ОУ15
            if (button69.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(14).Value.chState("blocked");
            }
            else if (button68.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(14).Value.chState("generator");
            }
            else if (button57.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(14).Value.chState("failure");
            }
            else if (button56.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(14).Value.chState("busy");
            }
            else lvs.clients.ElementAt(14).Value.chState("working");

            //ОУ16
            if (button67.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(15).Value.chState("blocked");
            }
            else if (button66.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(15).Value.chState("generator");
            }
            else if (button55.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(15).Value.chState("failure");
            }
            else if (button54.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(15).Value.chState("busy");
            }
            else lvs.clients.ElementAt(15).Value.chState("working");

            //ОУ17
            if (button65.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(16).Value.chState("blocked");
            }
            else if (button64.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(16).Value.chState("generator");
            }
            else if (button53.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(16).Value.chState("failure");
            }
            else if (button52.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(16).Value.chState("busy");
            }
            else lvs.clients.ElementAt(16).Value.chState("working");

            //ОУ18
            if (button63.BackColor != Color.Green)
            {
                lvs.clients.ElementAt(17).Value.chState("blocked");
            }
            else if (button62.BackColor == Color.Blue)
            {
                lvs.clients.ElementAt(17).Value.chState("generator");
            }
            else if (button51.BackColor == Color.Black)
            {
                lvs.clients.ElementAt(17).Value.chState("failure");
            }
            else if (button50.BackColor == Color.Orange)
            {
                lvs.clients.ElementAt(17).Value.chState("busy");
            }
            else lvs.clients.ElementAt(17).Value.chState("working");

            //конец инициализации 
            Random rand = new Random();
            lvs.working_18(t, false, rand);
            lvs.sb.Append("\n" + "Количество ошибок: " + "\n");
            lvs.sb.Append("Генерация: " + t[0] + "\r\nОтказ: " + t[1] + "\r\nСбой: " + t[2] + "\r\nАбонент занят: " + t[3] + "\n");
            lvs.sb.Append("total time: " + "\n");
            int time = lvs.ctrl.getTime();
            //time = time - 12*20*(18+2*t[1]-t[0]+t[2]+t[3]);//проверка работы без 12 слов данных
            lvs.sb.Append(time + "\n");
            richTextBox1.Text += lvs.sb.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor != Color.Red)
            {
                button45.BackColor = Color.Red;
                button44.Enabled = false;
                button32.Enabled = false;
                button33.Enabled = false;
            }
            else
            {
                button45.BackColor = Color.Green;
                button44.Enabled = true;
                button32.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (defect[5] == false) { defect[5] = true; button15.BackColor = Color.Black; }
            else if (button15.BackColor == Color.Black) 
            { defect[5] = false; button15.BackColor = SystemColors.Control; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[5] == false) 
                { gen = true; defect[5] = true; button13.BackColor = Color.Blue; } }
            else if (button13.BackColor == Color.Blue) if (defect[5] == true) 
                { gen = false; defect[5] = false; button13.BackColor = SystemColors.Control; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (defect[5] == false) { defect[5] = true; button14.BackColor = Color.Orange; }
            else if (button14.BackColor == Color.Orange) 
            { defect[5] = false; button14.BackColor = SystemColors.Control; }
        }

        private void button75_Click(object sender, EventArgs e)//старт сети
        {
            richTextBox1.Text = "";
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
            button49.Visible = true;
            button50.Visible = true;
            button51.Visible = true;
            button52.Visible = true;
            button53.Visible = true;
            button54.Visible = true;
            button55.Visible = true;
            button56.Visible = true;
            button57.Visible = true;
            button58.Visible = true;
            button59.Visible = true;
            button60.Visible = true;
            button61.Visible = true;
            button62.Visible = true;
            button63.Visible = true;
            button64.Visible = true;
            button65.Visible = true;
            button66.Visible = true;
            button67.Visible = true;
            button68.Visible = true;
            button69.Visible = true;
            button70.Visible = true;
            button71.Visible = true;
            button72.Visible = true;
            button73.Visible = true;
            button74.Visible = true;
            button76.Visible = true;
            button77.Visible = true;
            button76.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button10.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button49.BackColor = Color.Green;
            button47.BackColor = Color.Green;
            button45.BackColor = Color.Green;
            button43.BackColor = Color.Green;
            button41.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button73.BackColor = Color.Green;
            button71.BackColor = Color.Green;
            button69.BackColor = Color.Green;
            button67.BackColor = Color.Green;
            button65.BackColor = Color.Green;
            button63.BackColor = Color.Green;
            button77.BackColor = Color.Red;

            button75.Enabled = false;
            button1.Enabled = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (button77.BackColor == Color.Green) { button77.BackColor = Color.Red; button76.BackColor = Color.Green; }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (button76.BackColor == Color.Green) { button76.BackColor = Color.Red; button77.BackColor = Color.Green; }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button49.BackColor != Color.Red)
            {
                button49.BackColor = Color.Red;
                button48.Enabled = false;
                button37.Enabled = false;
                button36.Enabled = false;
            }
            else
            {
                button49.BackColor = Color.Green;
                button48.Enabled = true;
                button37.Enabled = true;
                button36.Enabled = true;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor != Color.Red)
            {
                button47.BackColor = Color.Red;
                button46.Enabled = false;
                button35.Enabled = false;
                button34.Enabled = false;
            }
            else
            {
                button47.BackColor = Color.Green;
                button46.Enabled = true;
                button35.Enabled = true;
                button34.Enabled = true;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor != Color.Red)
            {
                button43.BackColor = Color.Red;
                button42.Enabled = false;
                button31.Enabled = false;
                button30.Enabled = false;
            }
            else
            {
                button43.BackColor = Color.Green;
                button42.Enabled = true;
                button31.Enabled = true;
                button30.Enabled = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.BackColor != Color.Red)
            {
                button41.BackColor = Color.Red;
                button40.Enabled = false;
                button29.Enabled = false;
                button28.Enabled = false;
            }
            else
            {
                button41.BackColor = Color.Green;
                button40.Enabled = true;
                button29.Enabled = true;
                button28.Enabled = true;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor != Color.Red)
            {
                button39.BackColor = Color.Red;
                button38.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
            }
            else
            {
                button39.BackColor = Color.Green;
                button38.Enabled = true;
                button26.Enabled = true;
                button27.Enabled = true;
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (button73.BackColor != Color.Red)
            {
                button73.BackColor = Color.Red;
                button72.Enabled = false;
                button61.Enabled = false;
                button60.Enabled = false;
            }
            else
            {
                button73.BackColor = Color.Green;
                button72.Enabled = true;
                button61.Enabled = true;
                button60.Enabled = true;
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (button71.BackColor != Color.Red)
            {
                button71.BackColor = Color.Red;
                button70.Enabled = false;
                button59.Enabled = false;
                button58.Enabled = false;
            }
            else
            {
                button71.BackColor = Color.Green;
                button70.Enabled = true;
                button59.Enabled = true;
                button58.Enabled = true;
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (button69.BackColor != Color.Red)
            {
                button69.BackColor = Color.Red;
                button68.Enabled = false;
                button57.Enabled = false;
                button56.Enabled = false;
            }
            else
            {
                button69.BackColor = Color.Green;
                button68.Enabled = true;
                button57.Enabled = true;
                button56.Enabled = true;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (button67.BackColor != Color.Red)
            {
                button67.BackColor = Color.Red;
                button66.Enabled = false;
                button55.Enabled = false;
                button54.Enabled = false;
            }
            else
            {
                button67.BackColor = Color.Green;
                button66.Enabled = true;
                button55.Enabled = true;
                button54.Enabled = true;
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (button65.BackColor != Color.Red)
            {
                button65.BackColor = Color.Red;
                button64.Enabled = false;
                button52.Enabled = false;
                button53.Enabled = false;
            }
            else
            {
                button65.BackColor = Color.Green;
                button64.Enabled = true;
                button52.Enabled = true;
                button53.Enabled = true;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.BackColor != Color.Red)
            {
                button63.BackColor = Color.Red;
                button62.Enabled = false;
                button50.Enabled = false;
                button51.Enabled = false;
            }
            else
            {
                button63.BackColor = Color.Green;
                button62.Enabled = true;
                button50.Enabled = true;
                button51.Enabled = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //занят 
            if (defect[0] == false) { defect[0] = true; button24.BackColor = Color.Orange; }
            else if (button24.BackColor == Color.Orange) 
            { defect[0] = false; button24.BackColor = SystemColors.Control; }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //cбой
            if (defect[0] == false) { defect[0] = true; button25.BackColor = Color.Black; }
            else if (button25.BackColor == Color.Black) 
            { defect[0] = false; button25.BackColor = SystemColors.Control; }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[6] == false) { gen = true; defect[6] = true; 
                    button48.BackColor = Color.Blue; } }
            else if (button48.BackColor == Color.Blue) if (defect[6] == true) 
                { gen = false; defect[6] = false; button48.BackColor = SystemColors.Control; }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[7] == false) 
                { gen = true; defect[7] = true; button46.BackColor = Color.Blue; } }
            else if (button46.BackColor == Color.Blue) if (defect[7] == true) 
                { gen = false; defect[7] = false; button46.BackColor = SystemColors.Control; }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[8] == false) 
                { gen = true; defect[8] = true; button44.BackColor = Color.Blue; } }
            else if (button44.BackColor == Color.Blue) if (defect[8] == true) 
                { gen = false; defect[8] = false; button44.BackColor = SystemColors.Control; }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[9] == false) 
                { 
                    gen = true; defect[9] = true; 
                    button42.BackColor = Color.Blue; } }
            else if (button42.BackColor == Color.Blue) if (defect[9] == true) 
                { gen = false; defect[9] = false; button42.BackColor = SystemColors.Control; }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[10] == false) 
                { gen = true; defect[10] = true; button40.BackColor = Color.Blue; } }
            else if (button40.BackColor == Color.Blue) if (defect[10] == true) 
                { gen = false; defect[10] = false; button40.BackColor = SystemColors.Control; }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[11] == false) 
                { gen = true; defect[11] = true; button38.BackColor = Color.Blue; } }
            else if (button38.BackColor == Color.Blue) if (defect[11] == true) 
                { gen = false; defect[11] = false; button38.BackColor = SystemColors.Control; }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[12] == false) 
                { gen = true; defect[12] = true; button72.BackColor = Color.Blue; } }
            else if (button72.BackColor == Color.Blue) if (defect[12] == true) 
                { gen = false; defect[12] = false; button72.BackColor = SystemColors.Control; }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[13] == false) 
                { gen = true; defect[13] = true; button70.BackColor = Color.Blue; } }
            else if (button70.BackColor == Color.Blue) if (defect[13] == true) 
                { gen = false; defect[13] = false; button70.BackColor = SystemColors.Control; }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[14] == false) 
                { gen = true; defect[14] = true; button68.BackColor = Color.Blue; } }
            else if (button68.BackColor == Color.Blue) if (defect[14] == true) 
                { gen = false; defect[14] = false; button68.BackColor = SystemColors.Control; }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[15] == false) 
                { gen = true; defect[15] = true; button66.BackColor = Color.Blue; } }
            else if (button66.BackColor == Color.Blue) if (defect[15] == true) 
                { gen = false; defect[15] = false; button66.BackColor = SystemColors.Control; }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[16] == false) 
                { gen = true; defect[16] = true; button64.BackColor = Color.Blue; } }
            else if (button64.BackColor == Color.Blue) if (defect[16] == true) 
                { gen = false; defect[16] = false; button64.BackColor = SystemColors.Control; }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (gen == false) { if (defect[17] == false) 
                { gen = true; defect[17] = true; button62.BackColor = Color.Blue; } }
            else if (button62.BackColor == Color.Blue) if (defect[17] == true) 
                { gen = false; defect[17] = false; button62.BackColor = SystemColors.Control; }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (defect[1] == false) { defect[1] = true; button23.BackColor = Color.Black; }
            else if (button23.BackColor == Color.Black) 
            { defect[1] = false; button23.BackColor = SystemColors.Control; }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (defect[2] == false) { defect[2] = true; button21.BackColor = Color.Black; }
            else if (button21.BackColor == Color.Black) 
            { defect[2] = false; button21.BackColor = SystemColors.Control; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (defect[3] == false) { defect[3] = true; button19.BackColor = Color.Black; }
            else if (button19.BackColor == Color.Black) 
            { defect[3] = false; button19.BackColor = SystemColors.Control; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (defect[4] == false) { defect[4] = true; button17.BackColor = Color.Black; }
            else if (button17.BackColor == Color.Black) 
            { defect[4] = false; button17.BackColor = SystemColors.Control; }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (defect[6] == false) { defect[6] = true; button37.BackColor = Color.Black; }
            else if (button37.BackColor == Color.Black) 
            { defect[6] = false; button37.BackColor = SystemColors.Control; }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (defect[7] == false) { defect[7] = true; button35.BackColor = Color.Black; }
            else if (button35.BackColor == Color.Black) 
            { defect[7] = false; button35.BackColor = SystemColors.Control; }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (defect[8] == false) { defect[8] = true; button33.BackColor = Color.Black; }
            else if (button33.BackColor == Color.Black) 
            { defect[8] = false; button33.BackColor = SystemColors.Control; }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (defect[9] == false) { defect[9] = true; button31.BackColor = Color.Black; }
            else if (button31.BackColor == Color.Black) 
            { defect[9] = false; button31.BackColor = SystemColors.Control; }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (defect[10] == false) { defect[10] = true; button29.BackColor = Color.Black; }
            else if (button29.BackColor == Color.Black) 
            { defect[10] = false; button29.BackColor = SystemColors.Control; }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (defect[11] == false) { defect[11] = true; button27.BackColor = Color.Black; }
            else if (button27.BackColor == Color.Black) 
            { defect[11] = false; button27.BackColor = SystemColors.Control; }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (defect[12] == false) { defect[12] = true; button61.BackColor = Color.Black; }
            else if (button61.BackColor == Color.Black) 
            { defect[12] = false; button61.BackColor = SystemColors.Control; }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (defect[13] == false) { defect[13] = true; button59.BackColor = Color.Black; }
            else if (button59.BackColor == Color.Black) 
            { defect[13] = false; button59.BackColor = SystemColors.Control; }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (defect[14] == false) { defect[14] = true; button57.BackColor = Color.Black; }
            else if (button57.BackColor == Color.Black) 
            { defect[14] = false; button57.BackColor = SystemColors.Control; }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (defect[15] == false) { defect[15] = true; button55.BackColor = Color.Black; }
            else if (button55.BackColor == Color.Black) 
            { defect[15] = false; button55.BackColor = SystemColors.Control; }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (defect[16] == false) { defect[16] = true; button53.BackColor = Color.Black; }
            else if (button53.BackColor == Color.Black) 
            { defect[16] = false; button53.BackColor = SystemColors.Control; }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (defect[17] == false) { defect[17] = true; button51.BackColor = Color.Black; }
            else if (button51.BackColor == Color.Black) 
            { defect[17] = false; button51.BackColor = SystemColors.Control; }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (defect[1] == false) { defect[1] = true; button22.BackColor = Color.Orange; }
            else if (button22.BackColor == Color.Orange) 
            { defect[1] = false; button22.BackColor = SystemColors.Control; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (defect[2] == false) { defect[2] = true; button20.BackColor = Color.Orange; }
            else if (button20.BackColor == Color.Orange) 
            { defect[2] = false; button20.BackColor = SystemColors.Control; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (defect[3] == false) { defect[3] = true; button18.BackColor = Color.Orange; }
            else if (button18.BackColor == Color.Orange) 
            { defect[3] = false; button18.BackColor = SystemColors.Control; }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (defect[4] == false) { defect[4] = true; button16.BackColor = Color.Orange; }
            else if (button16.BackColor == Color.Orange) 
            { defect[4] = false; button16.BackColor = SystemColors.Control; }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (defect[6] == false) { defect[6] = true; button36.BackColor = Color.Orange; }
            else if (button36.BackColor == Color.Orange) 
            { defect[6] = false; button36.BackColor = SystemColors.Control; }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (defect[7] == false) { defect[7] = true; button34.BackColor = Color.Orange; }
            else if (button34.BackColor == Color.Orange) 
            { defect[7] = false; button34.BackColor = SystemColors.Control; }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (defect[8] == false) { defect[8] = true; button32.BackColor = Color.Orange; }
            else if (button32.BackColor == Color.Orange) 
            { defect[8] = false; button32.BackColor = SystemColors.Control; }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (defect[9] == false) { defect[9] = true; button30.BackColor = Color.Orange; }
            else if (button30.BackColor == Color.Orange) 
            { defect[9] = false; button30.BackColor = SystemColors.Control; }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (defect[10] == false) { defect[10] = true; button28.BackColor = Color.Orange; }
            else if (button28.BackColor == Color.Orange) 
            { defect[10] = false; button28.BackColor = SystemColors.Control; }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (defect[11] == false) { defect[11] = true; button26.BackColor = Color.Orange; }
            else if (button26.BackColor == Color.Orange)
            { defect[11] = false; button26.BackColor = SystemColors.Control; }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (defect[12] == false) { defect[12] = true; button60.BackColor = Color.Orange; }
            else if (button60.BackColor == Color.Orange) 
            { defect[12] = false; button60.BackColor = SystemColors.Control; }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (defect[13] == false) { defect[13] = true; button58.BackColor = Color.Orange; }
            else if (button58.BackColor == Color.Orange) 
            { defect[13] = false; button58.BackColor = SystemColors.Control; }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (defect[14] == false) { defect[14] = true; button56.BackColor = Color.Orange; }
            else if (button56.BackColor == Color.Orange) 
            { defect[14] = false; button56.BackColor = SystemColors.Control; }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (defect[15] == false) { defect[15] = true; button54.BackColor = Color.Orange; }
            else if (button54.BackColor == Color.Orange) 
            { defect[15] = false; button54.BackColor = SystemColors.Control; }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (defect[16] == false) { defect[16] = true; button52.BackColor = Color.Orange; }
            else if (button52.BackColor == Color.Orange) 
            { defect[16] = false; button52.BackColor = SystemColors.Control; }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (defect[17] == false) { defect[17] = true; button50.BackColor = Color.Orange; }
            else if (button50.BackColor == Color.Orange) 
            { defect[17] = false; button50.BackColor = SystemColors.Control; }
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private Button button42;
        private Button button43;
        private Button button44;
        private Button button45;
        private Button button46;
        private Button button47;
        private Button button48;
        private Button button49;
        private Button button50;
        private Button button51;
        private Button button52;
        private Button button53;
        private Button button54;
        private Button button55;
        private Button button56;
        private Button button57;
        private Button button58;
        private Button button59;
        private Button button60;
        private Button button61;
        private Button button62;
        private Button button63;
        private Button button64;
        private Button button65;
        private Button button66;
        private Button button67;
        private Button button68;
        private Button button69;
        private Button button70;
        private Button button71;
        private Button button72;
        private Button button73;
        private Button button74;
        private Button button75;
        private Button button76;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private RichTextBox richTextBox1;
        private Button button77;
    }
}
