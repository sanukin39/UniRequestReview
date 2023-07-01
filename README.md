# Archived
Use[RequestStoreReview](https://docs.unity3d.com/ScriptReference/iOS.Device.RequestStoreReview.html) Instead

# UniRequestReview

[![UnityVersion](https://img.shields.io/badge/Unity-2017.2.1f1-green.svg)](https://unity3d.com/jp/get-unity/download)
[![License](https://img.shields.io/badge/License-MIT-lightgrey.svg)](https://github.com/sanukin39/UniRequestReview/blob/master/LICENSE)

---

#### Request Default iOS Review Dialog Plugin for Unity
![unirequestreview](https://user-images.githubusercontent.com/6077255/34779363-4a357cca-f663-11e7-9837-7e874a8f3a1b.png)

## Requeirement
Unity5 or higher

## Install
Use unitypackage at [release page](https://github.com/sanukin39/UniRequestReview/releases).

## Implementation
Call method below when you want to request review.
```cs
UniRequestReview.RequestReview();
```

## Notes
The plugin is just wrap [requestReview()](https://developer.apple.com/documentation/storekit/skstorereviewcontroller/2851536-requestreview) method. So, it works only iOS10.3 or higher.

## Reference
[Apple Documentation - requestReview](https://developer.apple.com/documentation/storekit/skstorereviewcontroller/2851536-requestreview)

[Human Interface Guidelin - Ratings and Reviews](https://developer.apple.com/ios/human-interface-guidelines/system-capabilities/ratings-and-reviews/)

## Licence

[MIT](https://github.com/sanukin39/UniRequestReview/blob/master/LICENSE)

## Author

[sanukin39](https://github.com/sanukin39)
