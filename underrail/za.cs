using System;
using System.Runtime.Serialization;

// Token: 0x0200007A RID: 122
[eiz("SI")]
[Serializable]
public sealed class za : ISerializable
{
	// Token: 0x06000283 RID: 643 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
	private za(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("SI:I");
			this.b = A_0.GetString("SI:N");
			this.c = A_0.GetString("SI:SP");
			this.d = (b1g)A_0.GetValue("SI:DSSM", typeof(b1g));
			this.e = (bbs)A_0.GetValue("SI:DESM", typeof(bbs));
			this.f = A_0.GetString("SI:WUSI");
			if (ell.b() >= 27)
			{
				this.g = A_0.GetSingle("SI:VM");
				return;
			}
			this.g = 1f;
			return;
		}
		else
		{
			if (base.GetType() == typeof(za))
			{
				this.a = A_0.GetString("_Id");
				this.b = A_0.GetString("_Name");
				this.c = A_0.GetString("_SourcePath");
				this.d = (b1g)A_0.GetValue("_DefaultStartSongMode", typeof(b1g));
				this.e = (bbs)A_0.GetValue("_DefaultEndSongMode", typeof(bbs));
				this.f = A_0.GetString("_WrapUpSongId");
				return;
			}
			this.a = A_0.GetString("SongInfo+_Id");
			this.b = A_0.GetString("SongInfo+_Name");
			this.c = A_0.GetString("SongInfo+_SourcePath");
			this.d = (b1g)A_0.GetValue("SongInfo+_DefaultStartSongMode", typeof(b1g));
			this.e = (bbs)A_0.GetValue("SongInfo+_DefaultEndSongMode", typeof(bbs));
			this.f = A_0.GetString("SongInfo+_WrapUpSongId");
			return;
		}
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SI:I", this.a);
		info.AddValue("SI:N", this.b);
		info.AddValue("SI:SP", this.c);
		info.AddValue("SI:DSSM", this.d);
		info.AddValue("SI:DESM", this.e);
		info.AddValue("SI:WUSI", this.f);
		info.AddValue("SI:VM", this.g);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0000C964 File Offset: 0x0000AB64
	public string d()
	{
		return this.a;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0000C96C File Offset: 0x0000AB6C
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0000C978 File Offset: 0x0000AB78
	public string c()
	{
		return this.b;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0000C980 File Offset: 0x0000AB80
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0000C98C File Offset: 0x0000AB8C
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x0000C994 File Offset: 0x0000AB94
	public void d(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
	public bbs e()
	{
		return this.e;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
	public void a(bbs A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
	public b1g f()
	{
		return this.d;
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000C9BC File Offset: 0x0000ABBC
	public void a(b1g A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
	public string g()
	{
		return this.f;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000C9DC File Offset: 0x0000ABDC
	public float a()
	{
		return this.g;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
	public void a(float A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
	public za()
	{
	}

	// Token: 0x040003B4 RID: 948
	private string a;

	// Token: 0x040003B5 RID: 949
	private string b;

	// Token: 0x040003B6 RID: 950
	private string c;

	// Token: 0x040003B7 RID: 951
	private b1g d;

	// Token: 0x040003B8 RID: 952
	private bbs e;

	// Token: 0x040003B9 RID: 953
	private string f;

	// Token: 0x040003BA RID: 954
	private float g = 1f;
}
