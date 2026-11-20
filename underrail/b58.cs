using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x020006B3 RID: 1715
[eiz("RFD")]
[Serializable]
public class b58 : ISerializable
{
	// Token: 0x06002C82 RID: 11394 RVA: 0x000FEEDC File Offset: 0x000FD0DC
	protected b58(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("RFD:I");
		this.b = A_0.GetString("RFD:C");
		this.d = A_0.GetBoolean("RFD:N");
		di7.ReadList<string>("RFD:U", ref this.f, A_0);
		if (ell.a() >= 533)
		{
			di7.ReadList<ap>("RFD:P", ref this.g, A_0);
		}
		else
		{
			this.g = new List<ap>();
		}
		if (ell.a() >= 535)
		{
			this.e = A_0.GetString("RFD:D");
		}
		if (ell.a() >= 538)
		{
			this.h = (A_0.GetValue("RFD:MD", typeof(GameDifficulty?)) as GameDifficulty?);
			this.i = (A_0.GetValue("RFD:XD", typeof(GameDifficulty?)) as GameDifficulty?);
		}
		if (ell.a() >= 542)
		{
			this.c = A_0.GetString("RFD:CD");
		}
		if (ell.a() >= 635)
		{
			this.j = A_0.GetInt32("RFD:F");
			return;
		}
		this.j = 1;
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x000FF044 File Offset: 0x000FD244
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RFD:I", this.a);
		info.AddValue("RFD:C", this.b);
		info.AddValue("RFD:N", this.d);
		di7.WriteList<string>("RFD:U", this.f, info);
		di7.WriteList<ap>("RFD:P", this.g, info);
		info.AddValue("RFD:D", this.e);
		info.AddValue("RFD:MD", this.h);
		info.AddValue("RFD:XD", this.i);
		info.AddValue("RFD:CD", this.c);
		info.AddValue("RFD:F", this.j);
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x000FF108 File Offset: 0x000FD308
	public string m()
	{
		return this.a;
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x000FF110 File Offset: 0x000FD310
	public void f(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x000FF11C File Offset: 0x000FD31C
	public string q()
	{
		return this.b;
	}

	// Token: 0x06002C87 RID: 11399 RVA: 0x000FF124 File Offset: 0x000FD324
	public void h(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x000FF130 File Offset: 0x000FD330
	public string o()
	{
		return this.c;
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x000FF138 File Offset: 0x000FD338
	public void g(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x000FF144 File Offset: 0x000FD344
	public bool i()
	{
		return this.d;
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x000FF14C File Offset: 0x000FD34C
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x000FF158 File Offset: 0x000FD358
	public string l()
	{
		return this.e;
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x000FF160 File Offset: 0x000FD360
	public void e(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x000FF16C File Offset: 0x000FD36C
	public List<string> j()
	{
		return this.f;
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x000FF174 File Offset: 0x000FD374
	public void b(List<string> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x000FF180 File Offset: 0x000FD380
	public List<ap> n()
	{
		return this.g;
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x000FF188 File Offset: 0x000FD388
	public void a(List<ap> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x000FF194 File Offset: 0x000FD394
	public GameDifficulty? p()
	{
		return this.h;
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x000FF19C File Offset: 0x000FD39C
	public void a(GameDifficulty? A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x000FF1A8 File Offset: 0x000FD3A8
	public GameDifficulty? h()
	{
		return this.i;
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x000FF1B0 File Offset: 0x000FD3B0
	public void b(GameDifficulty? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x000FF1BC File Offset: 0x000FD3BC
	public int k()
	{
		return this.j;
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x000FF1C4 File Offset: 0x000FD3C4
	public void a(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x000FF1D0 File Offset: 0x000FD3D0
	public b58()
	{
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x000FF1F8 File Offset: 0x000FD3F8
	public virtual void afz(cyt A_0)
	{
		A_0.r()[string.Format("frag_{0}", this.a)] = true;
		ap.a(A_0, string.Format("frag_{0}_", this.a), this.g);
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x000FF238 File Offset: 0x000FD438
	public virtual bool af0(cyt A_0)
	{
		return (this.h == null || A_0.ae() >= this.h.Value) && (this.i == null || A_0.ae() <= this.i.Value) && (string.IsNullOrEmpty(this.c) || A_0.r().GetPrimitivePropertyValue<bool>(string.Format("dungeon_{0}", this.c), new bool?(false)).Value);
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x000FF2D8 File Offset: 0x000FD4D8
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			return this.a;
		}
		return "<Unnamed>";
	}

	// Token: 0x0400193C RID: 6460
	private string a;

	// Token: 0x0400193D RID: 6461
	private string b;

	// Token: 0x0400193E RID: 6462
	private string c;

	// Token: 0x0400193F RID: 6463
	private bool d;

	// Token: 0x04001940 RID: 6464
	private string e;

	// Token: 0x04001941 RID: 6465
	private List<string> f = new List<string>();

	// Token: 0x04001942 RID: 6466
	private List<ap> g = new List<ap>();

	// Token: 0x04001943 RID: 6467
	private GameDifficulty? h;

	// Token: 0x04001944 RID: 6468
	private GameDifficulty? i;

	// Token: 0x04001945 RID: 6469
	private int j = 1;
}
