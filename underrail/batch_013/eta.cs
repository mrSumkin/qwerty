using System;
using Ouroboros.Events;

// Token: 0x02000168 RID: 360
public interface eta
{
	// Token: 0x0600090D RID: 2317
	void RegisterHandler<T>(IGlobalEventHandler<T> handler) where T : dli;

	// Token: 0x0600090E RID: 2318
	void ao3(Type A_0, b61 A_1);

	// Token: 0x0600090F RID: 2319
	void UnregisterHandler<T>(IGlobalEventHandler<T> handler) where T : dli;

	// Token: 0x06000910 RID: 2320
	void ao4(Type A_0, b61 A_1);

	// Token: 0x06000911 RID: 2321
	void UnregisterHandlers<T>() where T : dli;

	// Token: 0x06000912 RID: 2322
	void ao5();

	// Token: 0x06000913 RID: 2323
	void ao6(dli A_0);
}
