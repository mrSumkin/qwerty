using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DDA RID: 3546
[e79("GenericFadeTransition")]
public sealed class ca9 : dgy
{
	// Token: 0x06004BE9 RID: 19433 RVA: 0x002101DC File Offset: 0x0020E3DC
	public ca9()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ca9.a a = new ca9.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("cutsceneSpeakerId");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					serviceOrThrow.aqu().r().RemoveProperty("cutsceneSpeakerId");
					Guid a_;
					if (Guid.TryParse(classPropertyValue, out a_))
					{
						a.b = (new ar7(a_, a.a.Area).ao() as c5x);
						if (a.b != null)
						{
							base.a(new btm[]
							{
								new ace(new e80(false))
							});
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(1.0))
							});
							btm[] array = new btm[1];
							int num = 0;
							dky dky = new dky();
							dky.a(0.2f);
							dky.a(false);
							array[num] = dky;
							base.a(array);
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(2.0))
							});
							btm[] array2 = new btm[1];
							int num2 = 0;
							c8s c8s = new c8s();
							c8s.a(0.2f);
							c8s.IsAsync = false;
							array2[num2] = c8s;
							base.a(array2);
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.a), null, null, null)
							});
							base.a(new btm[]
							{
								new ace(new e80(true))
							});
						}
					}
				}
			}
		}
	}

	// Token: 0x02000DDB RID: 3547
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BEB RID: 19435 RVA: 0x00210398 File Offset: 0x0020E598
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EA0 RID: 7840
		public c5x a;

		// Token: 0x04001EA1 RID: 7841
		public c5x b;
	}
}
