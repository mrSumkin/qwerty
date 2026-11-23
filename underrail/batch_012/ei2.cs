using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000A7 RID: 167
public interface ei2
{
	// Token: 0x060003C0 RID: 960
	List<Type> av2(Func<Type, bool> A_0);

	// Token: 0x060003C1 RID: 961
	[CompilerGenerated]
	void avy(EventHandler<EventArgs> A_0);

	// Token: 0x060003C2 RID: 962
	[CompilerGenerated]
	void avz(EventHandler<EventArgs> A_0);

	// Token: 0x060003C3 RID: 963
	List<Type> avx();

	// Token: 0x060003C4 RID: 964
	void av1();

	// Token: 0x060003C5 RID: 965
	Assembly av0(object A_0, ResolveEventArgs A_1);

	// Token: 0x060003C6 RID: 966
	Type av3(string A_0, string A_1, bool A_2 = true);

	// Token: 0x060003C7 RID: 967
	void av5(Type A_0, out string A_1, out string A_2, bool A_3 = false);

	// Token: 0x060003C8 RID: 968
	string av4(Type A_0);

	// Token: 0x060003C9 RID: 969
	string av6(MethodInfo A_0);

	// Token: 0x060003CA RID: 970
	MethodInfo av7(string A_0);
}
