using System;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AsyncService
    {
	    public async Task SomethingAsync()
	    {
#if NET40
			await TaskEx.Delay(1000);  
#else
		    await Task.Delay(1000);
#endif
		}
    }
}
