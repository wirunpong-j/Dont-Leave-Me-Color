   M S B A M L   `   `   `  ���� N  JDont Leave Me Color, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Dont_Leave_Me_ColorDont_Leave_Me_Color  #    Dont_Leave_Me_Color.HowToPlay   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:Dont_Leave_Me_Color     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  -     N� Title$  	HowToPlay��$
��1280��$	��720��|�.  J� IsHitTestVisible .  � 	Resources    htp g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%{  &	        �� $ Forever��.��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ Black��.\�  $ 0��$ 0Q�  $ 0:0:1.5��$	 144Q�  $ 0:0:2��$	 144Q�  $ 0:0:2.5��$	 144Q�U� $ (UIElement.Opacity)�$ enClick1��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2��$ 1Q�  $ 0:0:2.5��$ 1Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 Blue��.\�  $ 0��$ 0Q�  $ 0:0:1.5��$	 144Q�  $ 0:0:2��$	 144Q�  $ 0:0:2.5��$	 144Q�U� $ (UIElement.Opacity)�$ enClick2��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2��$ 1Q�  $ 0:0:2.5��$ 1Q�U� $ (UIElement.Opacity)�$ click1��.\�  $ 0:0:1.4��$	 0.3Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2��$ 1Q�  $ 0:0:2.5��$ 1Q�U� $ (UIElement.Opacity)�$ click3��.\�  $ 0:0:1.4��$	 0.3Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2��$ 1Q�  $ 0:0:2.5��$ 1Q�U� $ (UIElement.Opacity)�$ c1��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$
 0.15Q�  $ 0:0:2��$
 0.15Q�  $ 0:0:2.5��$
 0.15Q�U� $ (UIElement.Opacity)�$ c2��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$
 0.15Q�  $ 0:0:2��$
 0.15Q�  $ 0:0:2.5��$
 0.15Q�U� $ (UIElement.Opacity)�$ addPoint��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2.5��$ 1Q�U� $ (UIElement.Opacity)�$ loseLife��.\�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.42��$ 1Q�  $ 0:0:2.5��$ 1Q� � Triggers :� 	 :� RoutedEvent$	 FrameworkElement.Loaded��.[��� -   
 ��Name$
 htp_BeginStoryboard��#��[  :� $	 UIElement.KeyDown��.[���  �� BeginStoryboardName$ htp_BeginStoryboard��.��� .+��� -    ��Name$ image��$��Pic/Game Page BG.jpg��� $��90��$��400,45,400,0q�$	��Top=����	#FF5C3B1E.+��� -    ��Name$ 	textBlock��$
��Wrap=�$��How to play�� �� TextAlignment$ Center=�$��53.333(�$��Consolas Regular)�$��	0,10,0,14q�
��������� -   $ 
textBlock1��$
��Wrap=�$��170,164.04,170,0q�$��Consolas Regular)�$��33.333(�$ Center=�$��155.96��$	��Top=����	#FF5C3B1E�� $1�+Press D F J K When the colors reach the box���� �� $$�If press correctly get a point���� �� $7�1If press the indicated color you will lose a life���� -   $ textBlock1_Copy��$
��Wrap=�$��100,295.203,100,0q�$��Consolas Regular)�$��40(�$ Center=����	#FF5C3B1E$5��/-----------------------------------------------��$��55.663��$	��Top=��� -   $
 dont��$
��Wrap=�$
��Blue��$��66.667(�$ Center=����	#FF878787$��515,344.366,515,290q��� -   $ image1��$��50��$��Pic/quote1.png��$
��Left=�$��477,341.866,0,328.134q��� -	   $ image1_Copy��$��50��$��Pic/quote2.png��$��Right=�$��0,341.866,477,328.134q�� -
    �Name$ click1��$	��110��$	��134�����	#FFE800FF J� Opacity$	 0.3Q�$
��Left=�$��300,0,0,141q�$��Bottom=�� -   $ click3��$	��110�����	#FF00FF46$	 0.3Q�$��0,0,306,141q�$��Bottom=�$��Right=�$	��134���� -   $ image2��$��Right=�$��85��$	��Top=�$	��100��$��Pic/Start.png��$��	0,22,38,0q��� -   $ 
textBlock2��$��72.077��$��265,0,0,36.923q�$
��Wrap=�$��Bottom=�$��26.667(�$��Consolas Regular)�$ Center=�$
��Left=�$	��210���� $�Right���� �� $�Get 1 Point���� -   $ textBlock2_Copy��$��72.077��$��0,0,270,36.923q�$
��Wrap=�$��Bottom=�$��26.667(�$��Consolas Regular)�$ Center=�$��Right=�$	��210���� $�Wrong���� �� $�Lose a Life���� -   $ 
textBlock3��$��Right=�$��65.53��$��0,32.47,122,0q�$
��Wrap=�$	��Top=�$	��163��$��Consolas Regular)�$��26.667(�$ Center=��� $�Press ENTER���� �� $�to Play���� -   $ Black��$	��100��$
��Left=�$��316,321,0,299q�$��Pic/Colours/Black.png�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� �� -   $
 Blue��$	��100��$��Right=�$��0,321,324,299q�$��Pic/Colours/Blue1.png��$ 0.5,0.5&�z�V� .~��� �� �� T� �� -   $ noClick1��$
��Left=�$	��150��$��Bottom=�$	��156��$��Pic/tapNoClick.png��$��
354,0,0,81q��� -   $ enClick1��$
��Left=�$	��150��$��Bottom=�$	��156��$��Pic/tapClick.png��$��
354,0,0,81q�$ 0Q��� -   $ noClick2��$��Right=�$	��150��$��Bottom=�$	��156��$��Pic/tapNoClick.png��$��
0,0,240,81q��� -   $ enClick2��$��Right=�$	��150��$��Bottom=�$	��156��$��Pic/tapClick.png��$��
0,0,240,81q�$ 0Q�� -   $ c1��$
��Left=�$	��134��$��300,325,0,251q����	#FFE800FF$ 0Q�� -   $ c2��$��Right=�$	��134��$��0,321,306,255q����	#FF00FF46$ 0Q��� -   $ addPoint��$
��Left=�$��51��$��438,0,0,256q�$
��Wrap=�$��+1 Point��$��Bottom=�$	��156��$��Consolas Regular)�$��33.333(����	#FF0017FF$ 0Q��� -   $ loseLife��$��Right=�$��51��$��0,0,170,256q�$
��Wrap=�$��-1 Life��$��Bottom=�$	��131��$��Consolas Regular)�$��33.333(�
���  ��$ 0Q�