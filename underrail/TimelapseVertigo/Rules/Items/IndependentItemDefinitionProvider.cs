using System;
using System.Runtime.Serialization;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x0200222C RID: 8748
	[eiz("IIDP")]
	[Serializable]
	public sealed class IndependentItemDefinitionProvider<T> : bit, ISerializable where T : bk3
	{
		// Token: 0x0600CAF5 RID: 51957 RVA: 0x0047DA78 File Offset: 0x0047BC78
		private IndependentItemDefinitionProvider(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.b = (bk3)A_0.GetValue("IIDP:D", typeof(bk3));
				if (ell.a() >= 350)
				{
					this.c = (Version)A_0.GetValue("IIDP:V", typeof(Version));
					return;
				}
				this.c = new Version(0, 0, 0, 0);
				return;
			}
			else
			{
				if (base.GetType() == typeof(IndependentItemDefinitionProvider<T>))
				{
					this.b = (bk3)A_0.GetValue("_Definition", typeof(bk3));
					return;
				}
				this.b = (bk3)A_0.GetValue("IndependentItemDefinitionProvider`1+_Definition", typeof(bk3));
				return;
			}
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x0047DB5C File Offset: 0x0047BD5C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("IIDP:D", this.b);
			info.AddValue("IIDP:V", this.c);
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x0047DB84 File Offset: 0x0047BD84
		public bk3 wl()
		{
			if (this.c < dm9.d)
			{
				acj acj = IndependentItemDefinitionProvider<T>.a();
				if (acj != null)
				{
					acj.aqn(this.b, this.c);
					this.c = dm9.d;
				}
			}
			return this.b;
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x0047DBD8 File Offset: 0x0047BDD8
		public IndependentItemDefinitionProvider(T A_0)
		{
			czh.a(A_0, "itemDefinition");
			this.b = A_0;
		}

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x0047DC08 File Offset: 0x0047BE08
		public IndependentItemDefinitionProvider(T A_0, Version A_1)
		{
			czh.a(A_0, "itemDefinition");
			this.b = A_0;
			this.c = A_1;
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x0047DC40 File Offset: 0x0047BE40
		public bit wm()
		{
			return new IndependentItemDefinitionProvider<T>(this.b.tw() as T, this.c);
		}

		// Token: 0x0600CAFB RID: 51963 RVA: 0x0047DC64 File Offset: 0x0047BE64
		private static acj a()
		{
			if (IndependentItemDefinitionProvider<T>.a == null)
			{
				IndependentItemDefinitionProvider<T>.a = bpo.GetService<acj>();
			}
			return IndependentItemDefinitionProvider<T>.a;
		}

		// Token: 0x04004B0C RID: 19212
		private static acj a;

		// Token: 0x04004B0D RID: 19213
		private bk3 b;

		// Token: 0x04004B0E RID: 19214
		private Version c = dm9.d;
	}
}
