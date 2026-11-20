using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001E39 RID: 7737
[eiz("DSS")]
[Serializable]
public class axp : ech, ISerializable
{
	// Token: 0x0600AB7C RID: 43900 RVA: 0x003F6A80 File Offset: 0x003F4C80
	protected axp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB7D RID: 43901 RVA: 0x003F6A8C File Offset: 0x003F4C8C
	[OnDeserialized]
	internal void a(StreamingContext A_0)
	{
		int num = ell.a();
		if (num < 341)
		{
			if (!Enumerable.Any<csn>(base.d(), new Func<csn, bool>(axp.a.a.a)))
			{
				int index = base.d().FindIndex(new Predicate<csn>(axp.a.a.c)) + 1;
				base.d().Insert(index, new p5(aiy.ah, this));
			}
		}
		if (num < 662)
		{
			if (!Enumerable.Any<csn>(base.d(), new Func<csn, bool>(axp.a.a.b)))
			{
				base.d().Insert(1, new e8k(aiy.ah, this));
			}
		}
	}

	// Token: 0x0600AB7E RID: 43902 RVA: 0x003F6B78 File Offset: 0x003F4D78
	public axp()
	{
		this.a();
	}

	// Token: 0x0600AB7F RID: 43903 RVA: 0x003F6B88 File Offset: 0x003F4D88
	public axp(efk A_0) : base(A_0)
	{
		this.a();
	}

	// Token: 0x0600AB80 RID: 43904 RVA: 0x003F6B9C File Offset: 0x003F4D9C
	private void a()
	{
		base.d().Add(new ct7(aiy.ah, this));
		base.d().Add(new e8k(aiy.ah, this));
		base.d().Add(new dei(aiy.ah, this));
		base.d().Add(new e5n(aiy.ah, this));
		base.d().Add(new jk(aiy.ah, this));
		base.d().Add(new e74(aiy.ah, this));
		base.d().Add(new erc(aiy.ah, this));
		base.d().Add(new a2n(aiy.ah, this));
		base.d().Add(new adx(aiy.ah, this));
		base.d().Add(new dca(aiy.ah, this));
		base.d().Add(new bq0(aiy.ah, this));
		base.d().Add(new c0b(aiy.ah, this));
		base.d().Add(new eq1(aiy.ah, this));
		base.d().Add(new ij(aiy.ah, this));
		base.d().Add(new ii(aiy.ah, this));
		base.d().Add(new b6s(aiy.ah, this));
		base.d().Add(new qr(aiy.ah, this));
		base.d().Add(new dql(aiy.ah, this));
		base.d().Add(new fd(aiy.ah, this));
		base.d().Add(new rs(aiy.ah, this));
		base.d().Add(new p5(aiy.ah, this));
		base.d().Add(new bhn(aiy.ah, this));
		base.d().Add(new bec(aiy.ah, this));
		base.d().Add(new e70(aiy.ah, this));
	}

	// Token: 0x02001E3B RID: 7739
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600AB9C RID: 43932 RVA: 0x003F75B4 File Offset: 0x003F57B4
		internal bool a(csn A_0)
		{
			return A_0.GetType() == typeof(p5);
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x003F75CC File Offset: 0x003F57CC
		internal bool c(csn A_0)
		{
			return A_0.GetType() == typeof(rs);
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x003F75E4 File Offset: 0x003F57E4
		internal bool b(csn A_0)
		{
			return A_0.GetType() == typeof(e8k);
		}

		// Token: 0x04003FF7 RID: 16375
		public static readonly axp.a a = new axp.a();

		// Token: 0x04003FF8 RID: 16376
		public static Func<csn, bool> b;

		// Token: 0x04003FF9 RID: 16377
		public static Predicate<csn> c;

		// Token: 0x04003FFA RID: 16378
		public static Func<csn, bool> d;
	}
}
