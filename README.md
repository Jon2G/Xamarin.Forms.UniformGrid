# Xamarin.Forms.UniformGrid

_Simple Uniform Grid for Xamarin.Forms_



![Example](https://github.com/Jouna77/Xamarin.Forms.UniformGrid/blob/master/image.png?raw=true)


### Instalación 🔧

_Just add this package to your Xamarin project._

### Getting Started ⌨️

_Items Source Binding_

```
        <uniformgrid:UniformGrid VerticalOptions="FillAndExpand" BindableLayout.ItemsSource="{Binding UniformModel,Items}" ColumnSpacing="0" RowSpacing="0" BackgroundColor="Blue">
            <BindableLayout.EmptyView>
                <Label Text="No data"/>
            </BindableLayout.EmptyView>
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <Frame Padding="5" BackgroundColor="LightBlue" BorderColor="MidnightBlue">
                        <Label Text="{Binding Numero}" TextColor="Black"/>
                    </Frame>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </uniformgrid:UniformGrid>
```
_Sample_
        <uniformgrid:UniformGrid>
            <Frame BackgroundColor="AliceBlue">
                <Label Text="1"/>
            </Frame>
            <Frame BackgroundColor="Cornsilk">
                <Label Text="2"/>
            </Frame>
            <Frame BackgroundColor="DarkSalmon">
                <Label Text="3"/>
            </Frame>
            <Frame BackgroundColor="Gainsboro">
                <Label Text="4"/>
            </Frame>
            <Frame BackgroundColor="LightBlue">
                <Label Text="5"/>
            </Frame>
            <Frame BackgroundColor="MediumAquamarine">
                <Label Text="6"/>
            </Frame>
            <Frame BackgroundColor="MistyRose">
                <Label Text="7"/>
            </Frame>
        </uniformgrid:UniformGrid>

## Thank you 🎁
* Please feel free to colaborate ☕.
