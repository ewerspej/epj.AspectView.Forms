# epj.AspectView.Forms
![License](https://img.shields.io/github/license/ewerspej/epj.AspectView.Forms)
[![Nuget](https://img.shields.io/nuget/v/epj.AspectView.Forms)](https://www.nuget.org/packages/epj.AspectView.Forms/)

A type of *ContentView* for Xamarin.Forms that resizes itself based on the provided aspect ratio.

## Summary

Sometimes, when dealing with video views, I got extremely frustrated, because there was no practical way to keep the video view exactly in the size ratio of the video itself without letterboxing or stretching.

I could set the `WidthRequest` and `HeightRequest` properties according to the size ratio of the video, but then I wouldn't have the option to stretch the video across the entire screen width or height using the `HorizontalOptions` or `VerticalOptions`.

This is how the AspectView was conceived. It's a container for other ContentViews and always keeps the size ratio that you have set, which means you can box your video view, images or anything else inside of it, provide a size ratio and avoid letterboxing and stretching.

## Preview

<div>
    <img src="assets/portrait.jpg" align="top" width="240" /> 
    <img src="assets/landscape.jpg" align="top" height="240" />
</div>
<br />

This looks suspiciously similar like letterboxing, however it's not. In the case of letterboxing, the background would be black while we can actually see the Page background here, which means that we could add other controls and maintain the video's aspect without letterboxing.

## Usage

Simply install the package from nuget.org and then use it as follows:

```xml
<Grid>

  <forms:AspectView
    AspectRatio="0.5625"
    HorizontalOptions="Fill"
    VerticalOptions="Center">

    <videoPlayer:VideoPlayer
      Source="myvideo.mp4" />

  </forms:AspectView>

</Grid>
```

If you want to use a 16:9 ratio for videos, you would use 0.5625, like in the example.

### Important

The <em>AspectView</em> control uses the `HorizontalOptions` and `VerticalOptions` in combination with the `AspectRatio` property and only works when ***either*** the `HorizontalOptions` ***or*** the `VerticalOptions` property is set to `Fill`, ***but not both at the same time***. 

**Note:** The `AspectRatio` must have a value greater than `0.0` and by default is set to `1.0`, which means square.

## Acknowledgements

Video by <a href="https://pixabay.com/users/meditation_hypnosis-25780195/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=video&amp;utm_content=113403">Ivan</a> from <a href="https://pixabay.com//?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=video&amp;utm_content=113403">Pixabay</a>
