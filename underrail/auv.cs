using System;
using System.Runtime.CompilerServices;

// Token: 0x02000287 RID: 647
[eiz("iACT")]
public interface auv
{
	// Token: 0x060012DE RID: 4830
	void j();

	// Token: 0x060012DF RID: 4831
	void k();

	// Token: 0x060012E0 RID: 4832
	[CompilerGenerated]
	void l(EventHandler<EventArgs> A_0);

	// Token: 0x060012E1 RID: 4833
	[CompilerGenerated]
	void m(EventHandler<EventArgs> A_0);

	// Token: 0x060012E2 RID: 4834
	dc4 n(TimeSpan A_0, TimeSpan A_1);

	// Token: 0x060012E3 RID: 4835
	[CompilerGenerated]
	void o(EventHandler<EventArgs> A_0);

	// Token: 0x060012E4 RID: 4836
	[CompilerGenerated]
	void p(EventHandler<EventArgs> A_0);

	// Token: 0x060012E5 RID: 4837
	[CompilerGenerated]
	void q(EventHandler<EventArgs> A_0);

	// Token: 0x060012E6 RID: 4838
	[CompilerGenerated]
	void r(EventHandler<EventArgs> A_0);

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x060012E7 RID: 4839
	Guid Id { get; }

	// Token: 0x060012E8 RID: 4840
	[CompilerGenerated]
	void t(EventHandler<EventArgs> A_0);

	// Token: 0x060012E9 RID: 4841
	[CompilerGenerated]
	void u(EventHandler<EventArgs> A_0);

	// Token: 0x060012EA RID: 4842
	bool v(cix A_0);

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x060012EB RID: 4843
	string Name { get; }

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060012EC RID: 4844
	dc4 State { get; }

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060012ED RID: 4845
	cix Manager { get; }

	// Token: 0x060012EE RID: 4846
	void z(cix A_0);
}
