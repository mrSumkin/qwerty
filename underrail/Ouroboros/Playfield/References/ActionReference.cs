using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

namespace Ouroboros.Playfield.References
{
	// Token: 0x02002215 RID: 8725
	[eiz("AR1")]
	[Serializable]
	public sealed class ActionReference<T> : TypedObjectReference<T>, ISerializable where T : class, auv
	{
		// Token: 0x0600CA83 RID: 51843 RVA: 0x0047BDD0 File Offset: 0x00479FD0
		public ActionReference(T A_0)
		{
			if (A_0 != null && A_0.Manager != null && A_0.Manager.g7() != null && A_0.Manager.g7().Playfield != null)
			{
				base.a(new Guid?(A_0.Id));
				this.b = A_0.Manager.g7().qe();
				this.a = A_0.Manager.g7().Playfield.Name;
				base.a(A_0);
			}
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x0047BE88 File Offset: 0x0047A088
		private ActionReference(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			if (ell.b() != 0)
			{
				this.b = (Guid)A_0.GetValue("AR1:ZI", typeof(Guid?));
				this.a = A_0.GetString("AR1:PN");
				return;
			}
			if (base.GetType() == typeof(TypedObjectReference<T>))
			{
				this.b = (Guid)A_0.GetValue("_ZoneId", typeof(Guid));
				this.a = A_0.GetString("_PlayfieldName");
				return;
			}
			this.b = (Guid)A_0.GetValue("ActionReference`1+_ZoneId", typeof(Guid));
			this.a = A_0.GetString("ActionReference`1+_PlayfieldName");
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x0047BF58 File Offset: 0x0047A158
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("AR1:ZI", this.b);
			info.AddValue("AR1:PN", this.a);
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x0047BF8C File Offset: 0x0047A18C
		protected override T h4()
		{
			if (string.IsNullOrEmpty(this.a) || base.afl() == null)
			{
				return default(T);
			}
			d6j service = bpo.GetService<d6j>();
			if (service != null)
			{
				e3h e3h = service.dx(this.a);
				if (e3h != null)
				{
					c1a c1a = e3h.a(this.b);
					if (c1a != null && c1a.ActionManager != null)
					{
						return c1a.ActionManager.hg(base.afl().Value) as T;
					}
				}
			}
			return default(T);
		}

		// Token: 0x04004A13 RID: 18963
		private string a;

		// Token: 0x04004A14 RID: 18964
		private Guid b;
	}
}
