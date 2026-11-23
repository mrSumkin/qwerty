using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001916 RID: 6422
[elw(typeof(dng))]
[eiz("AI2")]
[Serializable]
public sealed class dgr : dj3, ISerializable
{
	// Token: 0x0600886F RID: 34927 RVA: 0x00387B10 File Offset: 0x00385D10
	private dgr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (AmmoType)A_0.GetValue("AI2:T", typeof(AmmoType));
		if (ell.a() >= 261)
		{
			di7.ReadList<edm>("AI2:H", ref this.c, A_0);
			return;
		}
		this.c = new List<edm>();
	}

	// Token: 0x06008870 RID: 34928 RVA: 0x00387B7C File Offset: 0x00385D7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AI2:T", this.b);
		di7.WriteList<edm>("AI2:H", this.c, info);
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x00387BB0 File Offset: 0x00385DB0
	public override string tv()
	{
		return "Боеприпасы";
	}

	// Token: 0x06008872 RID: 34930 RVA: 0x00387BB8 File Offset: 0x00385DB8
	public AmmoType b()
	{
		return this.b;
	}

	// Token: 0x06008873 RID: 34931 RVA: 0x00387BC0 File Offset: 0x00385DC0
	public new void a(AmmoType A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x00387BCC File Offset: 0x00385DCC
	public new List<edm> a()
	{
		return this.c;
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x00387BD4 File Offset: 0x00385DD4
	public dgr()
	{
		base.f(250);
	}

	// Token: 0x06008876 RID: 34934 RVA: 0x00387BF4 File Offset: 0x00385DF4
	public override bk3 tw()
	{
		dgr dgr = new dgr();
		this.ai7(dgr);
		return dgr;
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x00387C10 File Offset: 0x00385E10
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		dgr dgr = A_0 as dgr;
		dgr.b = this.b;
		if (this.c != null)
		{
			dgr.c.AddRange(Enumerable.Select<edm, edm>(this.c, new Func<edm, edm>(dgr.a.a.a)));
		}
	}

	// Token: 0x0400367B RID: 13947
	private new const int a = 250;

	// Token: 0x0400367C RID: 13948
	private AmmoType b;

	// Token: 0x0400367D RID: 13949
	private List<edm> c = new List<edm>();

	// Token: 0x02001917 RID: 6423
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600887A RID: 34938 RVA: 0x00387C90 File Offset: 0x00385E90
		internal edm a(edm A_0)
		{
			return A_0.g();
		}

		// Token: 0x0400367E RID: 13950
		public static readonly dgr.a a = new dgr.a();

		// Token: 0x0400367F RID: 13951
		public static Func<edm, edm> b;
	}
}
