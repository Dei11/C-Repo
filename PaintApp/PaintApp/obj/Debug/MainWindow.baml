   M S B A M L   `   `   `  ����C  ?PaintApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PaintAppPaintApp  5   	       PaintApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PaintApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ newBtn��5      $	��New��6+    m� Icon 5      �� 5      $��./Resources/New-File.png��6    5      m� 5      -   5        $ saveBtn��5      $
��Save��6,    5      �� 5      $��./Resources/Save.png��6    5      m� 5      -   5        $ openBtn��5      $
��Open��6,    5      �� 5      $!��./Resources/Folder-Open.png��6    5      5      m� 5      $
��Edit��6   .@�5       m� -   5        $ 	brushSize��5       $��
Brush Size��6.    5"      �� 5#      $ ��./Resources/Brush-size.png��6    .@�5&      m� -   5        $ onePx��5&      $	��1px��6.    m� IsCheckable .  m� StaysOpenOnClick . 6f   m� 5'      -   5        $ threePx��5'      $	��3px��60    .  .  m� 	IsChecked . 6y   m� 5(      -   5        $ fivePx��5(      $	��5px��6/    .  . 6g   m� 5)      -   5        $ eightPx��5)      $	��8px��60    .  . 6h   5*      m� 5+      $��Brush Color��6    5-      �� 5.      $��./Resources/Color.png��6    .@�51      m� -	   5        $ 
blackColor��51      $��Black��63    .  .  . 6~   m� 52      -
   5        $ redColor��52      $	��Red��61    .  . 6i   m� 53      -   5        $ 
greenColor��53      $��Green��63    .  . 6m   m� 54      -   5        $ 	blueColor��54      $
��Blue��62    .  . 6k   55      57      58      �� 59   
   $
��Left=�6   $	��427��60   $	��Top=�6>   $	��800��6V   $��0,23,-6.4,-30q�6b   .@�5:      �� $
��Draw��6   .��5;      �� ���	#FFE5E5E5$��0,0,0.4,25.6q�64   .+�5<      c� -   5        $��drawingToolbar��5<      $��50��64   .@�5=      	� -   5        $��
DrawButton��5=   &   ���	#FFD2D2D2$
��Draw��6O   $��50��6^   $��80��6j    	� 	GroupName$ 	DrawGroup��6�   	� 5>      -   5        $��EraseButton��5>   &   ���	#FFD2D2D2$��Erase��6P   $��50��6`   $��80��6l   $ 	DrawGroup��6�   	� 5?      -   5        $��SelectButton��5?   &   ���	#FFD2D2D2$��Select��6Q   $��50��6b   $��80��6n   $ 	DrawGroup��6�   5@      �� 5A      -   5        $��DrawingCanvas��5A       $	��347��65   $��	0,0,0.4,0q�6B    �� DefaultDrawingAttributes 5B      *  $System.Windows.Ink.DrawingAttributes  5C      -   5        
strokeAttr��   Width$ 3Q�5C   D   	   Height$	 3Q�6N   
   Color$
 Black��6Y   5E      5F      5G      5H      5I      5J      