   M S B A M L   `   `   `  ���� N  JDont Leave Me Color, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Dont_Leave_Me_ColorDont_Leave_Me_Color  "    Dont_Leave_Me_Color.MainPlay   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:Dont_Leave_Me_Color     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  -     N� Title$  MainPlay��$
��1280��$	��720��|�.  J� IsHitTestVisible .  � 	Resources    	storyOver �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� .��U� $ (UIElement.Opacity)�$ 
gameoverBG��.\�  $ 0��$ 0Q�  $ 0:0:2��$	 0.7Q�U� $ (UIElement.Opacity)�$ gameOverText��.\�  $ 0��$ 0Q�  $ 0:0:2��$ 1Q�U� $ (UIElement.Opacity)�$ yourScoreText��.\�  $ 0��$ 0Q�  $ 0:0:2��$ 1Q�U� $ (UIElement.Opacity)�$ 
pressAgain��.\�  $ 0��$ 0Q�  $ 0:0:2��$ 1Q� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��	 N� 
Background	 �� 
 �� ImageSource$
 Pic/Game Page BG.jpg�� j� Stretch$
 Fill=�.��� .+��� $��-19.667,0,0,0q�.+��� ���	#FFF1CC01$��5��$	��612�� �� Left$	 345��
 �� Top$ 54��$	��570���� $	��612��$	��567��$	 345��$ 54��.+�� -    �Name$ c1��$	��481��$ 10��$ 10��$	��134�����	#FFE800FF J� Opacity$ 0Q�� -   $ c2��$	��481��$	 149��$ 10��$	��134�����	#FF00B9D6$ 0Q�� -   $ c3��$	��481��$	 288��$ 10��$	��134�����	#FF00FF46$ 0Q�� -   $ c4��$	��481��$	 427��$ 10��$	��134�����	#FFDCFF00$ 0Q��� -    ��Name$
 tap1��$	��592��$ 10��$ 10��$	��134��.+�� -   $ click1��$	��110��$	��134��$	 482�����	#FFE800FF$	 0.3Q�.+��� -    ��Name$ D��$
��Wrap=�$��D��$��66.667(� �� TextAlignment$ Center=�
��������� -	   $
 tap2��$	��592��$	 149��$ 10��$	��134��.+�� -
   $ click2��$	��110��$	��134��$	 482�����	#FF00B9D6$	 0.3Q�.+��� -   $ F��$
��Wrap=�$��F��$��66.667(�$ Center=�
��������� -   $
 tap3��$	��592��$	 288��$ 10��$	��134��.+�� -   $ click3��$	��110��$	��134��$	 482�����	#FF00FF46$	 0.3Q�.+��� -   $ J��$
��Wrap=�$��J��$��66.667(�$ Center=�
��������� -   $
 tap4��$	��592��$	 427��$ 10��$	��134��.+�� -   $ click4��$	��110��$	��134��$	 482�����	#FFDCFF00$	 0.3Q�.+��� -   $ K��$
��Wrap=�$��K��$��66.667(�$ Center=�
�������� $��62��$	 914��$ 62��$	��193�����	#FFF1CC01.+��� -   $ 	levelText��$
��Wrap=�$��LEVEL: 1��$ Center=�$��40(�$��Consolas Regular)�$��0,6,0,4q�
�������� $��45.333��$	 912��$ 148.659��$��157.667�����	#FFF1CC01.+��� -   $ lifeText��$
��Wrap=�$��LIFE: 5��$ Center=�$��32(�$��Consolas Regular)�$��0,4.666,0,5.334q�
��������� -    ��Name$ image��$��74��$	 282��$	 380��$	��100��$��
Pic/B1.png��� $
��82.5��$��199.5��$ 89.667��$
 72.5�����	#FF5C3B1E.+��� -   $ 	scoreText��$��SCORE: 0��
�������$��32(�$ Center=�$��	0,21,0,24q�$��Consolas Regular)�$
��Wrap=��� -   $
 dont��$��71��$ 981.167��$
��Wrap=�$��	TextBlock��$	 301��$	��250��$��46.667(�$ Center=����	#FF878787�� -   $ image1��$��50��$��50��$��Pic/quote1.png��$ 939.167��$ 284.5���� -   $ image1_Copy��$��50��$��50��$��Pic/quote2.png��$ 1215.167��$ 284.5���� -   $ image_Copy1��$��74��$	��100��$��
Pic/B2.png��$
��Left=�$��
42,215,0,0q�$	��Top=��� -   $ image_Copy2��$	��113��$	��127��$��
Pic/B3.png��$��Right=�$��
0,152,28,0q�$	��Top=��� -   $ image_Copy3��$	��164��$	��244��$��Pic/home.png��$
��Left=�$��	54,0,0,59q�$��Bottom=��� -   $ image_Copy4��$	��164��$	��127��$��Pic/Tree.png��$��Right=�$��
0,0,208,59q�$��Bottom=��� -   $ image_Copy5��$	��125��$��85��$��Pic/Bike.png��$��Right=�$��
0,0,165,59q�$��Bottom=�� -   $ 
gameoverBG��
�������$ 0Q��� -   $ gameOverText��$��289,231,289,0q�$
��Wrap=�$��- GAME OVER -��$��Consolas Regular)�$��96(�$	��125��$	��Top=�$ 0Q���Z� �� -    $ yourScoreText��$��289,347.5,289,316.5q�$
��Wrap=�$��Your Score: ��$��Consolas Regular)�$��50.667(�$ Center=����	#FFFF6800$ 0Q���Z� �� -!   $ 
pressAgain��$��289,0,289,234.5q�$
��Wrap=�$��Press ENTER to Restart��$��Consolas Regular)�$��46.667(�$ Center=�$��56��$��Bottom=�$ 0Q���Z� r� -"    r�Name$ soundTap��$��Right=�$	��114��$��
0,0,-135,0q�$��Bottom=�$	��100�� r� LoadedBehavior$ Manual=� r� UnloadedBehavior$
 Stop=� r� Source$ Pic/Sounds/Bell.wav?�r� -#   $ music��$��Right=�$	��114��$��
0,0,-270,0q�$��Bottom=�$	��110��$! Pic/Sounds/Pangya Music.mp3?�$ Manual=�$
 Stop=�r� -$   $ gameOverSound��$��Right=�$	��114��$��0,0,-205,135q�$��Bottom=�$	��110��$# Pic/Sounds/GameOverEffect.mp3?�$ Manual=�$
 Stop=�