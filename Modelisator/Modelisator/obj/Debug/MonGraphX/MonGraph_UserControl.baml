   M S B A M L   `   `   `  ����F  BModelisator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Modelisator.MonGraphXModelisator.MonGraphX  5      0    *Modelisator.MonGraphX.MonGraph_UserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RGraphX.Controls, Version=2.2.0.0, Culture=neutral, PublicKeyToken=bab23663f80c9e761graphx$http://schemas.panthernet.ru/graphx/  5      5simpleGraph#clr-namespace:Modelisator.MonGraphX  5        � 	Resources  5
         demoTemplate �� DataType&    Modelisator.MonGraphX.DataVertex �� Orientation � ToolTip �� Path �� Mode �� StringFormat#  GraphX.Controls.VertexControl �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Padding'  !GraphX.Controls.VertexControlBase   Vertex J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   Color   Opacity   	Direction!  GraphX.Controls.EdgeControl �� 	Resources  Key  ToolTipContent��%E  &	        '  B    7   '      7  �� 5   
   "  6,   .R�5      �� $��
PanelNoeud��62   $ 
Horizontal=�6   ��6D   �� *GP.CouleurBackG+ 5      _� 5      .��5      �� ��6$   �� $ GP.Description�$ OneWay=�6Y   5      .+�5      �� $��TextId��6   -   5        $
��Bold"�5   S   
���   �$��5q�6�   ��6+   �� $
 Text�$ OneWay=�6�   �� 5      $��3q�6�   ��6   �� $ 	GP.Valeur�$ TwoWay=�$ N2����6Z   �� *GP.CouleurNoeud+6�   �� 5      
���   �$��5q�6Y   ��6   �� $
 Unit�$ OneWay=�6Y   5      5      �� 5      "  6   .�5      ��  � ��	 5      �� 5      "
  6"   .R�5      �� $��ContentVertex��6%   
�������
�������$��2q�5      $ 10,10,10,10��5      # z��5       ._�5!      �� $ Vertical=�6)   $��Center=�6@   $��Center=�6]   .+�5"   &   �� #��z 67   8��  5#   1   5$       5%        5&      $ 3Q�6/   $ 	LightGray��6>   $	 0.3Q�5'   %   $	 315Q�63   5)      5*      5,      5-      �� 50      "  6    51   
   ��_� 52      ToolTipContent .��53      �� .+�54      �� $
��Bold"�6    $��Edge Information��62   �� 55      ��6    �� *ID+56      57      58      .�59   
   ��  �@�ToolTip8	   6$   5:      5<      .��5=      !  GraphX.Controls.ZoomControl  -   5          Name$ zoomctrl��5=      $��1��6+   .��5>      ,   &Modelisator.MonGraphX.GraphAreaExample  -   5          Name$
 Area��5>   +   5?      5A      