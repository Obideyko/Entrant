   M S B A M L   `   `   `  ���� F  BEntrantApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EntrantApps.PagesEntrantApps.Pages  '    !EntrantApps.Pages.CertificatePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:EntrantApps.Pages     -     N� Title$  CertificatePage��.���  � RowDefinitions �� $��40 ��� $
��200* ��� $��50 �.+�� $��0��$��3��.+���  �� Orientation$ 
Horizontal=�$	��450��$��30��$��5q�.+��� $G��AВведите номер аттестата для поиска:��$��Center=�$
��Left=�$��14(��� -   $
��tBox��$	��200��$��24��$��5 0 0 0q� � Cursor$ Arrow��$��14(�&   System.Windows.Controls.DataGrid  -   $��DGridCertificate��$��1��$��3��   AutoGenerateColumns .     
IsReadOnly . ��Z� ��Z�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *Entrant.Name+  $ 
Номер��$
 auto 	 �� *Number+  $ Русский язык��$
 auto 	 �� *Russian_language+  $ Литература��$
 auto 	 �� *
Literature+  $ Родной язык��$
 auto 	 �� *Native_language+  $' !Родная литература��$
 auto 	 �� *Nativa_literature+  $ Алгебра��$
 auto 	 �� *	Algebra+  $ Геометрия��$
 auto 	 �� *
Geometry+  $ История��$
 auto 	 �� *	History+  $" Обществознание��$
 auto 	 �� *Social_studies+  $ География��$
 auto 	 �� *	Geography+  $ Физика��$
 auto 	 �� *	Physics+  $ Биология��$
 auto 	 �� *	Biology+  $ 
Химия��$
 auto 	 �� *	Chemistry+  $% Иностранный язык��$
 auto 	 �� *Foreign_language+  $ ОБЖ��$
 auto 	 �� *OBZH+  $ Информатика��$
 auto 	 �� *Informatics+  $ Физкультура��$
 auto 	 �� *Physica_culture+  $ Технология��$
 auto 	 �� *
Technology+  $ Искусство��$
 auto 	 �� *Art+  $ Музыка��$
 auto 	 �� *Music+  $ Средний балл��$
 auto 	 �� *	Average+4  .System.Windows.Controls.DataGridTemplateColumn  $
 auto 
   CellTemplate
 �� .R���  ��Name$ EditBtn��-   $ ��Редактировать��
����������#000000���	#FF7E7E7E$
 Hand��  $
 auto -   CalculateColumns��
 �� .R��� $ CalculateBtn��-   $��Рассчитать��
����������#000000���	#FF7E7E7E$
 Hand���� -   $ AddBtn��$��Добавить��$��2��$��20 0 0 0q�$
��Left=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand���� -   $ DelBtn��$��Удалить��$��2��$��Center=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand���� -	   $ ExBtn��$"��Экспортировать��$��2��$��0 0 20 0q�$��Right=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand��