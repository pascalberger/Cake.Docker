﻿using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Docker
{
    // Contains functionality for working with docker buildx use command.
    partial class DockerAliases
    {
        /// <summary>
        /// Set the current builder instance using default settings.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="name">The name.</param>
        [CakeMethodAlias]
        public static void DockerBuildXUse(this ICakeContext context, string name)
        {
            context.DockerBuildXUse(name);
        }
        /// <summary>
        /// Set the current builder instance given <paramref name="settings"/>.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="name">The name.</param>
        [CakeMethodAlias]
        public static void DockerBuildXUse(this ICakeContext context, DockerBuildXUseSettings settings = null, string name = null)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var runner = new GenericDockerRunner<DockerBuildXUseSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.Run("buildx use", new DockerBuildXUseSettings(), new string[] { name });
        }
    }
}
