   M S B A M L   `   `   `  ���� F  BEntrantApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EntrantApps.PagesEntrantApps.Pages  #    EntrantApps.Pages.EntrantPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:EntrantApps.Pages     -     N� Title$  EntrantPage��.���  � RowDefinitions �� $
��Auto ��� $
��200* ��� $��50 �.+�� $��0��$��3��$��Center=�.+��� $	��420��$��30��$��5q� �� Orientation$ 
Horizontal=�.+��� $0��*Введите ФИО для поиска:��$��Center=�$
��Left=�$��14(��� -   $
��tBox��$
��Left=�$	��220��$��24��$��10 0 0 0q� � Cursor$ Arrow��$��14(��� $	��420��$��30��$��5q�$ 
Horizontal=�.+��� $2��,Выберите специальность:��$��Center=�$��14(��� -   $��	ComboSpec�� �� DisplayMemberPath$
 Name��$	��220��$��24��$��10 0 0 0q�$��14(�&   System.Windows.Controls.DataGrid  -   $��DGridEntrant��$��1��$��3��   AutoGenerateColumns .     
IsReadOnly . ��Z� ��Z�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 Auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *ID+  $ ФИО��$
	 auto 
 �� *Name+  $ Средний балл��$
	 auto 
 �� *Certificate1.Average+  $ Дата рождения��$
	 auto 
 �� *
Birthday+ �� StringFormat$ {0:dd.MM.yyyy}��  $! Место рождения��$
	 auto 
 �� *Place_of_birth+  $ Паспорт��$
	 auto 
 �� *
Passport+  $% Когда и кем выдан��$
	 auto 
 �� *Whem_and_by_whom_issued+  $% Место проживания��$
	 auto 
 �� *Place_of_residence+  $ 
СНИЛС��$
	 auto 
 �� *SNILS+  $ 
Полис��$
	 auto 
 �� *Medical_policy+  $# Номер аттестата��$
	 auto 
 �� *Certificate1.Number+  $ Телефон��$
	 auto 
 �� *	Telephone+  $  Специальность��$
	 auto 
 �� *Specialization.Name+4  .System.Windows.Controls.DataGridTemplateColumn  $
	 auto    CellTemplate �� .R���  ��Name$ EditBtn��-   $ ��Редактировать��
����������#000000���	#FF7E7E7E$
 Hand���� -   $ AddBtn��$��Добавить��$��2��$��20 0 0 0q�$
��Left=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand���� -   $ DelBtn��$��Удалить��$��2��$��Center=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand���� -   $ ExBtn��$"��Экспортировать��$��2��$��0 0 20 0q�$��Right=�$	��175��
����������#000000���	#FF7E7E7E$
 Hand��