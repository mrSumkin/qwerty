using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

namespace Ouroboros.Playfield.References
{
	// Token: 0x02002216 RID: 8726
	[eiz("EAR")]
	[Serializable]
	public sealed class EntityAspectReference<TAspect, TBaseAspect> : TypedObjectReference<TAspect>, ISerializable where TAspect : class, TBaseAspect where TBaseAspect : cn7
	{
		// Token: 0x0600CA87 RID: 51847 RVA: 0x0047C034 File Offset: 0x0047A234
		private EntityAspectReference(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			if (ell.b() != 0)
			{
				this.a = A_0.GetString("EAR:PN");
				this.b = (Guid)A_0.GetValue("EAR:ZI", typeof(Guid));
				this.c = (Guid)A_0.GetValue("EAR:AI", typeof(Guid));
				return;
			}
			if (base.GetType() == typeof(EntityAspectReference<TAspect, TBaseAspect>))
			{
				this.a = A_0.GetString("_PlayfieldName");
				this.b = (Guid)A_0.GetValue("_ZoneId", typeof(Guid));
				this.c = (Guid)A_0.GetValue("_AreaId", typeof(Guid));
				return;
			}
			this.a = A_0.GetString("EntityAspectReference`2+_PlayfieldName");
			this.b = (Guid)A_0.GetValue("EntityAspectReference`2+_ZoneId", typeof(Guid));
			this.c = (Guid)A_0.GetValue("EntityAspectReference`2+_AreaId", typeof(Guid));
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x0047C164 File Offset: 0x0047A364
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("EAR:PN", this.a);
			info.AddValue("EAR:ZI", this.b);
			info.AddValue("EAR:AI", this.c);
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x0047C1B8 File Offset: 0x0047A3B8
		public string c()
		{
			return this.a;
		}

		// Token: 0x0600CA8A RID: 51850 RVA: 0x0047C1C0 File Offset: 0x0047A3C0
		public Guid b()
		{
			return this.b;
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x0047C1C8 File Offset: 0x0047A3C8
		public Guid a()
		{
			return this.c;
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x0047C1D4 File Offset: 0x0047A3D4
		public EntityAspectReference(TAspect A_0)
		{
			if (A_0 != null)
			{
				b0b b0b = A_0.Container as b0b;
				if (b0b != null && b0b.Area != null && b0b.Area.Zone != null && b0b.Area.Zone.Playfield != null)
				{
					base.a(new Guid?(b0b.qe()));
					this.c = b0b.Area.qe();
					this.b = b0b.Area.Zone.qe();
					this.a = b0b.Area.Zone.Playfield.Name;
					base.a(A_0);
				}
			}
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x0047C294 File Offset: 0x0047A494
		public EntityAspectReference(aud A_0, Guid A_1)
		{
			if (A_0 != null && A_0.Zone != null && A_0.Zone.Playfield != null)
			{
				base.a(new Guid?(A_1));
				this.c = A_0.qe();
				this.b = A_0.Zone.qe();
				this.a = A_0.Zone.Playfield.Name;
			}
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x0047C308 File Offset: 0x0047A508
		public EntityAspectReference(string A_0, Guid A_1, Guid A_2, Guid A_3)
		{
			base.a(new Guid?(A_3));
			this.c = A_2;
			this.b = A_1;
			this.a = A_0;
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x0047C338 File Offset: 0x0047A538
		protected override TAspect h4()
		{
			if (string.IsNullOrEmpty(this.a) || base.afl() == null)
			{
				return default(TAspect);
			}
			d6j service = bpo.GetService<d6j>();
			if (service != null)
			{
				e3h e3h = service.dx(this.a);
				if (e3h != null)
				{
					c1a c1a = e3h.a(this.b);
					if (c1a != null)
					{
						aud aud = c1a.d(this.c);
						if (aud != null)
						{
							b0b b0b = aud.a(base.afl().Value);
							if (b0b == null)
							{
								foreach (aud aud2 in c1a.Areas)
								{
									if (aud2 != aud)
									{
										b0b = aud2.a(base.afl().Value);
										if (b0b != null)
										{
											break;
										}
									}
								}
							}
							if (b0b != null)
							{
								return b0b.GetAspect<TBaseAspect>() as TAspect;
							}
						}
					}
				}
			}
			return default(TAspect);
		}

		// Token: 0x04004A15 RID: 18965
		private string a;

		// Token: 0x04004A16 RID: 18966
		private Guid b;

		// Token: 0x04004A17 RID: 18967
		private Guid c;
	}
}
