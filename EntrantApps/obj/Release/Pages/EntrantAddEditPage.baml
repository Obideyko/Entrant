   M S B A M L   `   `   `  ���� F  BEntrantApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EntrantApps.PagesEntrantApps.Pages  *    $EntrantApps.Pages.EntrantAddEditPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:EntrantApps.Pages       N� Title$  EntrantAddEditPage��.���  � RowDefinitions �� $��* ��� $��60 �.+��� $��0��$
��Auto=�.��� $��10q�.+�� $	��350��$��10q�.+��� $��ФИО��$
��Left=��� $��Right=�$	��200��$��24������ *Name+� $	��350��$��10q�.+��� $��Дата рождения��$
��Left=�(  "System.Windows.Controls.DatePicker  -     Name$ 
datePicker��$��Right=�$	��200��$��24��   SelectedDate �� *
Birthday+ �� StringFormat$ {0:dd.MM.yyyy}��� $	��350��$��10q�.+��� $!��Место рождения��$
��Left=��� $��Right=�$	��200��$��24������ *Place_of_birth+� $	��350��$��10q�.+��� $��Паспорт��$
��Left=��� -    ��Name$ pasText�� �� 	MaxLength$ 10��$��Right=�$	��200��$��24������ *
Passport+� $	��350��$��10q�.+��� $%��Когда и кем выдан��$
��Left=��� $��Right=�$	��200��$��24������ *Whem_and_by_whom_issued+� $	��350��$��10q�.+��� $%��Место проживания��$
��Left=��� $��Right=�$	��200��$��24������ *Place_of_residence+� $	��350��$��10q�.+��� $��
СНИЛС��$
��Left=��� -   $ 	snilsText��$ 11��$��Right=�$	��200��$��24������ *SNILS+� $	��350��$��10q�.+��� $��
Полис��$
��Left=��� -   $ 
policyText��$ 16��$��Right=�$	��200��$��24������ *Medical_policy+� $	��350��$��10q�.+��� $#��Номер аттестата��$
��Left=��� -    ��Name$ ComboCertificate�� �� DisplayMemberPath$ Number��$��Right=�$	��200��$��24��	 �� SelectedItem	 �� *Certificate1+� $	��350��$��10q�.+��� $��Телефон��$
��Left=��� -   $ telText��$ 11��$��Right=�$	��200��$��24������ *	Telephone+� $	��350��$��10q�.+��� $ ��Специальность��$
��Left=��� -   $ ComboSpecialization��$
 Name��$��Right=�$	��200��$��24��	 �� *Specialization+�� -   
 ��Name$
 BtnSave��$��Сохранить��$��1��$	��200��
����������#000000���	#FF7E7E7E � Cursor$
 Hand��