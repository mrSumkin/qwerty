using System;
using System.Runtime.CompilerServices;

// Token: 0x02000027 RID: 39
[eiz("iIAC")]
public interface cuw
{
	// Token: 0x06000087 RID: 135
	[CompilerGenerated]
	void act(EventHandler<bdu> A_0);

	// Token: 0x06000088 RID: 136
	[CompilerGenerated]
	void acu(EventHandler<bdu> A_0);

	// Token: 0x06000089 RID: 137
	[CompilerGenerated]
	void acv(EventHandler<bdu> A_0);

	// Token: 0x0600008A RID: 138
	[CompilerGenerated]
	void acw(EventHandler<bdu> A_0);

	// Token: 0x0600008B RID: 139
	void ac1();

	// Token: 0x0600008C RID: 140
	cn7 acx(Type A_0);

	// Token: 0x0600008D RID: 141
	T GetAspect<T>() where T : cn7;

	// Token: 0x0600008E RID: 142
	bool ac0(Type A_0);

	// Token: 0x0600008F RID: 143
	bool RemoveAspect<T>();

	// Token: 0x06000090 RID: 144
	void acz(cn7 A_0, Type A_1);

	// Token: 0x06000091 RID: 145
	void acy(cn7 A_0);

	// Token: 0x06000092 RID: 146
	void SetAspect<T>(T aspect) where T : cn7;
}
