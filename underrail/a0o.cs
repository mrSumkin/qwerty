using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02001873 RID: 6259
[e79("Test")]
[eiz("T2")]
[Serializable]
public sealed class a0o : dgy, ISerializable
{
	// Token: 0x0600851C RID: 34076 RVA: 0x00375634 File Offset: 0x00373834
	private a0o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(a0o);
		}
	}

	// Token: 0x0600851D RID: 34077 RVA: 0x00375660 File Offset: 0x00373860
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600851E RID: 34078 RVA: 0x0037566C File Offset: 0x0037386C
	public a0o()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		base.a(new btm[]
		{
			new ace(new e80(false))
		});
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(1.0))
		});
		kw kw = new kw();
		kw.a(new float?(3f));
		kw.c().a("spawnPoint");
		base.a(new btm[]
		{
			kw
		});
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(1.0))
		});
		no no = new no();
		no.a(new e6z(serviceOrThrow.aqw().g("spawnPoint").Area));
		no.a(serviceOrThrow.aqw().g("spawnPoint").Location);
		no.a("smoke");
		no.a(1);
		base.a(new btm[]
		{
			new ace(no)
		});
		ace ace = new ace(new ezd("Locale\\Creatures\\HeadmonsterSpitter", new bt4("spawnPoint"), new HorizontalDirection?(HorizontalDirection.South), null, null, null, null));
		base.a(new btm[]
		{
			ace
		});
		base.a(new btm[]
		{
			new os(TimeSpan.FromSeconds(1.0))
		});
		elq elq = new elq();
		elq.b().b("starEntity");
		base.a(new btm[]
		{
			elq
		});
		base.a(new btm[]
		{
			new btw()
		});
		d92 d = new d92();
		d.a(new ar7(new Guid("49755afc-b5c1-442a-8b65-d377f056c725"), serviceOrThrow.aqu().v().b().Area));
		d.b(new ar7(serviceOrThrow.aqu().v().b()));
		d.a("Test");
		base.a(new btm[]
		{
			d
		});
		base.a(new btm[]
		{
			new ace(new e80(true))
		});
	}

	// Token: 0x0600851F RID: 34079 RVA: 0x003758B8 File Offset: 0x00373AB8
	protected override List<btm> ti(Exception A_0, btm A_1)
	{
		List<btm> list = base.ti(A_0, A_1) ?? new List<btm>();
		if (Enumerable.Any<btm>(base.d(), new Func<btm, bool>(a0o.a.a.b)))
		{
			if (!Enumerable.Any<btm>(base.d(), new Func<btm, bool>(a0o.a.a.a)))
			{
				list.Add(new btw());
			}
		}
		if (Enumerable.Count<ace>(Enumerable.OfType<ace>(base.d()), new Func<ace, bool>(a0o.a.a.a)) == 1)
		{
			list.Add(new ace(new e80(true)));
		}
		return list;
	}

	// Token: 0x02001874 RID: 6260
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008522 RID: 34082 RVA: 0x003759A8 File Offset: 0x00373BA8
		internal bool b(btm A_0)
		{
			return A_0 is elq;
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x003759B4 File Offset: 0x00373BB4
		internal bool a(btm A_0)
		{
			return A_0 is btw;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x003759C0 File Offset: 0x00373BC0
		internal bool a(ace A_0)
		{
			return A_0.Job is e80;
		}

		// Token: 0x040032FF RID: 13055
		public static readonly a0o.a a = new a0o.a();

		// Token: 0x04003300 RID: 13056
		public static Func<btm, bool> b;

		// Token: 0x04003301 RID: 13057
		public static Func<btm, bool> c;

		// Token: 0x04003302 RID: 13058
		public static Func<ace, bool> d;
	}
}
