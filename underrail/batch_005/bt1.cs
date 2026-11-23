using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001E69 RID: 7785
[eiz("IJD0")]
[Serializable]
public sealed class bt1 : ISerializable
{
	// Token: 0x0600ACCE RID: 44238 RVA: 0x003FA770 File Offset: 0x003F8970
	private bt1(SerializationInfo A_0, StreamingContext A_1)
	{
		this.e(A_0.GetString("I"));
		this.d(A_0.GetString("T"));
		this.a(A_0.GetString("G"));
		this.a(A_0.GetValue("J", typeof(object)));
		this.b(A_0.GetString("L"));
		this.a(A_0.GetValue("C", typeof(PropertyCollection)) as PropertyCollection);
		this.b(A_0.GetInt32("A"));
		this.a((dsk)A_0.GetValue("D", typeof(dsk)));
		this.a(A_0.GetBoolean("X"));
		this.b(A_0.GetBoolean("Y"));
		this.c(A_0.GetString("B"));
		this.f(A_0.GetString("E"));
		if (ell.a() >= 615)
		{
			this.a(A_0.GetInt32("P"));
		}
	}

	// Token: 0x0600ACCF RID: 44239 RVA: 0x003FA8B0 File Offset: 0x003F8AB0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("I", this.b());
		info.AddValue("T", this.m());
		info.AddValue("G", this.g());
		info.AddValue("J", this.d());
		info.AddValue("L", this.a());
		info.AddValue("C", this.k());
		info.AddValue("A", this.e());
		info.AddValue("P", this.h());
		info.AddValue("D", this.j());
		info.AddValue("X", this.i());
		info.AddValue("Y", this.l());
		info.AddValue("B", this.f());
		info.AddValue("E", this.c());
	}

	// Token: 0x0600ACD0 RID: 44240 RVA: 0x003FA9A0 File Offset: 0x003F8BA0
	[CompilerGenerated]
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600ACD1 RID: 44241 RVA: 0x003FA9A8 File Offset: 0x003F8BA8
	[CompilerGenerated]
	public void e(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600ACD2 RID: 44242 RVA: 0x003FA9B4 File Offset: 0x003F8BB4
	[CompilerGenerated]
	public string m()
	{
		return this.b;
	}

	// Token: 0x0600ACD3 RID: 44243 RVA: 0x003FA9BC File Offset: 0x003F8BBC
	[CompilerGenerated]
	public void d(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600ACD4 RID: 44244 RVA: 0x003FA9C8 File Offset: 0x003F8BC8
	[CompilerGenerated]
	public string g()
	{
		return this.c;
	}

	// Token: 0x0600ACD5 RID: 44245 RVA: 0x003FA9D0 File Offset: 0x003F8BD0
	[CompilerGenerated]
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600ACD6 RID: 44246 RVA: 0x003FA9DC File Offset: 0x003F8BDC
	[CompilerGenerated]
	public object d()
	{
		return this.d;
	}

	// Token: 0x0600ACD7 RID: 44247 RVA: 0x003FA9E4 File Offset: 0x003F8BE4
	[CompilerGenerated]
	public void a(object A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600ACD8 RID: 44248 RVA: 0x003FA9F0 File Offset: 0x003F8BF0
	[CompilerGenerated]
	public string a()
	{
		return this.e;
	}

	// Token: 0x0600ACD9 RID: 44249 RVA: 0x003FA9F8 File Offset: 0x003F8BF8
	[CompilerGenerated]
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600ACDA RID: 44250 RVA: 0x003FAA04 File Offset: 0x003F8C04
	[CompilerGenerated]
	public PropertyCollection k()
	{
		return this.f;
	}

	// Token: 0x0600ACDB RID: 44251 RVA: 0x003FAA0C File Offset: 0x003F8C0C
	[CompilerGenerated]
	public void a(PropertyCollection A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600ACDC RID: 44252 RVA: 0x003FAA18 File Offset: 0x003F8C18
	[CompilerGenerated]
	public int e()
	{
		return this.g;
	}

	// Token: 0x0600ACDD RID: 44253 RVA: 0x003FAA20 File Offset: 0x003F8C20
	[CompilerGenerated]
	public void b(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600ACDE RID: 44254 RVA: 0x003FAA2C File Offset: 0x003F8C2C
	[CompilerGenerated]
	public int h()
	{
		return this.h;
	}

	// Token: 0x0600ACDF RID: 44255 RVA: 0x003FAA34 File Offset: 0x003F8C34
	[CompilerGenerated]
	public void a(int A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600ACE0 RID: 44256 RVA: 0x003FAA40 File Offset: 0x003F8C40
	[CompilerGenerated]
	public dsk j()
	{
		return this.i;
	}

	// Token: 0x0600ACE1 RID: 44257 RVA: 0x003FAA48 File Offset: 0x003F8C48
	[CompilerGenerated]
	public void a(dsk A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600ACE2 RID: 44258 RVA: 0x003FAA54 File Offset: 0x003F8C54
	[CompilerGenerated]
	public bool i()
	{
		return this.j;
	}

	// Token: 0x0600ACE3 RID: 44259 RVA: 0x003FAA5C File Offset: 0x003F8C5C
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600ACE4 RID: 44260 RVA: 0x003FAA68 File Offset: 0x003F8C68
	[CompilerGenerated]
	public bool l()
	{
		return this.k;
	}

	// Token: 0x0600ACE5 RID: 44261 RVA: 0x003FAA70 File Offset: 0x003F8C70
	[CompilerGenerated]
	public void b(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600ACE6 RID: 44262 RVA: 0x003FAA7C File Offset: 0x003F8C7C
	[CompilerGenerated]
	public string f()
	{
		return this.l;
	}

	// Token: 0x0600ACE7 RID: 44263 RVA: 0x003FAA84 File Offset: 0x003F8C84
	[CompilerGenerated]
	public void c(string A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600ACE8 RID: 44264 RVA: 0x003FAA90 File Offset: 0x003F8C90
	[CompilerGenerated]
	public string c()
	{
		return this.m;
	}

	// Token: 0x0600ACE9 RID: 44265 RVA: 0x003FAA98 File Offset: 0x003F8C98
	[CompilerGenerated]
	public void f(string A_0)
	{
		this.m = A_0;
	}

	// Token: 0x0600ACEA RID: 44266 RVA: 0x003FAAA4 File Offset: 0x003F8CA4
	public bt1()
	{
	}

	// Token: 0x04004051 RID: 16465
	[CompilerGenerated]
	private string a;

	// Token: 0x04004052 RID: 16466
	[CompilerGenerated]
	private string b;

	// Token: 0x04004053 RID: 16467
	[CompilerGenerated]
	private string c;

	// Token: 0x04004054 RID: 16468
	[CompilerGenerated]
	private object d;

	// Token: 0x04004055 RID: 16469
	[CompilerGenerated]
	private string e;

	// Token: 0x04004056 RID: 16470
	[CompilerGenerated]
	private PropertyCollection f = new PropertyCollection();

	// Token: 0x04004057 RID: 16471
	[CompilerGenerated]
	private int g;

	// Token: 0x04004058 RID: 16472
	[CompilerGenerated]
	private int h;

	// Token: 0x04004059 RID: 16473
	[CompilerGenerated]
	private dsk i = dsk.c;

	// Token: 0x0400405A RID: 16474
	[CompilerGenerated]
	private bool j = true;

	// Token: 0x0400405B RID: 16475
	[CompilerGenerated]
	private bool k;

	// Token: 0x0400405C RID: 16476
	[CompilerGenerated]
	private string l;

	// Token: 0x0400405D RID: 16477
	[CompilerGenerated]
	private string m;
}
