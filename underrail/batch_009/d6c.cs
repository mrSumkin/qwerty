using System;
using Microsoft.Xna.Framework.Audio;

// Token: 0x02000070 RID: 112
public sealed class d6c
{
	// Token: 0x0600021F RID: 543 RVA: 0x0000B350 File Offset: 0x00009550
	public dv5 a()
	{
		return this.a;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000B358 File Offset: 0x00009558
	public SoundEffect e()
	{
		return this.b;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000B360 File Offset: 0x00009560
	public bool c()
	{
		return this.b != null;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000B36C File Offset: 0x0000956C
	public d6c(dv5 A_0)
	{
		czh.a(A_0, "sfxInfo");
		this.a = A_0;
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000B388 File Offset: 0x00009588
	public bool b()
	{
		bool result = false;
		if (this.a.b() != null)
		{
			bpo.GetServiceOrThrow<cne>().ut(this.a.b());
			result = true;
		}
		this.b = null;
		return result;
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000B3C8 File Offset: 0x000095C8
	public bool d()
	{
		if (this.b != null && this.b.IsDisposed)
		{
			this.b = null;
		}
		if (this.b == null && this.a.b() != null)
		{
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			this.b = serviceOrThrow.GetResource<SoundEffect>(this.a.b(), new double?((double)-1));
		}
		return this.b != null;
	}

	// Token: 0x0400038B RID: 907
	private dv5 a;

	// Token: 0x0400038C RID: 908
	private SoundEffect b;
}
