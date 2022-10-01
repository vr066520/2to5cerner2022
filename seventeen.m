#import <Foundation/Foundation.h>
/*cerner_2^5_2022*/
int main (int argc, const char * argv[])
{
        NSAutoreleasePool *pool = [[NSAutoreleasePool alloc] init];
        NSLog (@"Hello World");
        [pool drain];
        return 0;
}