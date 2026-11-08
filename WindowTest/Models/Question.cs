<Window x:Class="WindowTest.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Window Test"
        Width="1100"
        Height="760"
        WindowStartupLocation="CenterScreen"
        Background="#EEF3FF"
        FontFamily="Segoe UI">
    <Grid Margin="24">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <Border Grid.Row="0"
                CornerRadius="20"
                Background="#2F6FED"
                Padding="22"
                Margin="0,0,0,18">
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>

                <StackPanel>
                    <TextBlock Text="Window Test"
                               FontSize="30"
                               FontWeight="Bold"
                               Foreground="White"/>
                    <TextBlock Text="Modern Windows 10 assessment app"
                               Margin="0,6,0,0"
                               FontSize="14"
                               Foreground="#EAF2FF"/>
                </StackPanel>

                <StackPanel Grid.Column="1" Orientation="Horizontal" VerticalAlignment="Center">
                    <TextBlock Text="Strategy:"
                               Foreground="White"
                               FontSize="14"
                               Margin="0,0,10,0"
                               VerticalAlignment="Center"/>
                    <ComboBox x:Name="StrategyComboBox"
                              Width="220"
                              Height="34"
                              ItemsSource="{Binding StrategyOptions}"
                              SelectedItem="{Binding SelectedStrategy, Mode=TwoWay}"
                              SelectedIndex="0"/>
                </StackPanel>
            </Grid>
        </Border>

        <Border Grid.Row="1"
                Background="White"
                BorderBrush="#DDE7FF"
                BorderThickness="1"
                CornerRadius="20"
                Padding="28">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="*"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>

                <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="0,0,0,18">
                    <TextBlock Text="{Binding ProgressText}"
                               FontWeight="Bold"
                               FontSize="16"
                               Foreground="#1A1E2D"/>
                    <TextBlock Text="{Binding ScoreText}"
                               Margin="24,0,0,0"
                               FontWeight="SemiBold"
                               FontSize="14"
                               Foreground="#2F6FED"/>
                </StackPanel>

                <Border Grid.Row="1"
                        Background="#F6F9FF"
                        CornerRadius="14"
                        Padding="18"
                        Margin="0,0,0,18">
                    <StackPanel>
                        <TextBlock Text="{Binding StrategyTitle}"
                                   Foreground="#2F6FED"
                                   FontWeight="Bold"
                                   FontSize="13"
                                   Margin="0,0,0,8"/>
                        <TextBlock Text="{Binding CurrentQuestion.Text}"
                                   FontSize="22"
                                   FontWeight="SemiBold"
                                   TextWrapping="Wrap"
                                   Foreground="#1A1E2D"/>
                    </StackPanel>
                </Border>

                <TextBlock Grid.Row="2"
                           Text="Choose the best answer:"
                           Foreground="#4B5266"
                           FontSize="14"
                           Margin="0,0,0,10"/>

                <ListBox Grid.Row="3"
                         x:Name="AnswerListBox"
                         ItemsSource="{Binding CurrentOptions}"
                         SelectedIndex="{Binding SelectedAnswerIndex, Mode=TwoWay}"
                         BorderThickness="0"
                         Background="Transparent"
                         Padding="0">
                    <ListBox.ItemTemplate>
                        <DataTemplate>
                            <Border CornerRadius="12"
                                    Background="#F7F9FF"
                                    BorderBrush="#DDE7FF"
                                    BorderThickness="1"
                                    Padding="14"
                                    Margin="0,0,0,8">
                                <TextBlock Text="{Binding }"
                                           FontSize="17"
                                           TextWrapping="Wrap"/>
                            </Border>
                        </DataTemplate>
                    </ListBox.ItemTemplate>
                </ListBox>

                <StackPanel Grid.Row="4" Orientation="Horizontal" HorizontalAlignment="Right" Margin="0,18,0,0">
                    <Button x:Name="SubmitButton"
                            Width="180"
                            Height="42"
                            Content="Submit answer"
                            Background="#2F6FED"
                            Foreground="White"
                            FontWeight="SemiBold"
                            Margin="0,0,12,0"
                            IsEnabled="{Binding CanSubmit}"/>
                    <Button x:Name="NextButton"
                            Width="180"
                            Height="42"
                            Content="Next question"
                            Background="#173E7A"
                            Foreground="White"
                            FontWeight="SemiBold"
                            IsEnabled="{Binding CanNext}"/>
                </StackPanel>
            </Grid>
        </Border>

        <Border x:Name="ResultBanner"
                Grid.Row="2"
                Background="#E8F8F0"
                CornerRadius="16"
                Padding="18"
                Margin="0,16,0,0"
                Visibility="Collapsed">
            <TextBlock x:Name="ResultBannerText"
                       FontSize="16"
                       FontWeight="SemiBold"
                       Foreground="#0F6C3B"
                       Text="Result"/>
        </Border>
    </Grid>
</Window>
