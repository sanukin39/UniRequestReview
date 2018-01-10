#import <StoreKit/StoreKit.h>

extern "C" {
    void _RequestReview(){
        [SKStoreReviewController requestReview];
    }
}
